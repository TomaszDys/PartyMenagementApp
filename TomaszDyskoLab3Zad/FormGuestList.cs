using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaszDyskoLab3Zad
{
    public partial class FormGuestList : Form
    {
        /// <summary>
        /// Przyszłe połączenie do naszej bazy danych
        /// </summary>
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny w którym łączymy się do bazy danych i wyświetlamy zawatrość tabeli goście
        /// </summary>
        public FormGuestList()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
            BindCloaks();
        }
        /// <summary>
        /// Metoda uruchamiana po kliknięciu przcisku która dodaje wartość do bazy danych i odświerza widok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            InsertData(connection,
                       textBoxName.Text.Trim(),
                       textBoxSurname.Text.Trim(),
                       Int32.Parse(comboBoxCloaks.Text));
            DisplayWholeTable();
        }
        /// <summary>
        /// Funkcja przekazująca dane do bazy używając parametrów oraz tranzakcji
        /// </summary>
        private void InsertData(SqlConnection connectionString, string name, string surname, int cloak)
        {
            
            connection.Open();
            //Deklaruję nową tranzakcję oraz zapytanie sql
            SqlTransaction sqlTransaction = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Transaction = sqlTransaction;
            command.Connection = connection;
            //Sprawdzam czy jest możliwe wykonanie tej operacji, jeśli jest to wykonuję a jeśli nie to wykonuję RollBack i o błędzie informuję w messageboxie
            try
            {
                command.CommandText = $"INSERT INTO Guests(Name,Surname) VALUES (@Name, @Surname);";
                command.Parameters.Add("@Name", SqlDbType.VarChar, 31).Value = name;
                command.Parameters.Add("@Surname", SqlDbType.VarChar, 31).Value = surname;
                command.ExecuteNonQuery();
                command.CommandText = $"INSERT INTO CloakGuest(GuestId, CloakId) Values(IDENT_CURRENT('Guests') , @CloakId)";
                command.Parameters.Add("@CloakId", SqlDbType.Int).Value = cloak;
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                //Jeśli się nie udało to wyrzucam błędy
                MessageBox.Show(ex.Message);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }
            }
            connection.Close();
        }
        /// <summary>
        /// Metoda wywołana po kliknięciu przycisku reset, resetująca widok do wyświetlania całej tabeli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            DisplayWholeTable();
        }
        /// <summary>
        /// Kod usunięcia aktywnej komórki źródło:
        /// https://stackoverflow.com/questions/5539243/how-to-delete-a-selected-row-from-datagridview-and-database
        /// </summary>
        private void DeleteRecord()
        {
            if (dataGridViewGuestList.SelectedRows.Count > 0)
            {
                ///Zmienna przechowująca index zaznaczonego rzędu
                int selectedIndex = dataGridViewGuestList.SelectedRows[0].Index;
                ///Zmienna przechowująca potrzebny mi index gościa
                int rowId = int.Parse(dataGridViewGuestList[0, selectedIndex].Value.ToString());
                ///Zmienna przchowująca zaputanie sql
                string sql = "DELETE FROM Guests WHERE Id = @RowID";
                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = connection;
                deleteRecord.CommandType = CommandType.Text;
                deleteRecord.CommandText = sql;
                
                SqlParameter RowParameter = new SqlParameter();
                RowParameter.ParameterName = "@RowID";
                RowParameter.SqlDbType = SqlDbType.Int;
                RowParameter.IsNullable = false;
                RowParameter.Value = rowId;
                deleteRecord.Parameters.Add(RowParameter);
                deleteRecord.Connection.Open();
                deleteRecord.ExecuteNonQuery();
                deleteRecord.Connection.Close();
            }
        }
        /// <summary>
        /// Metoda wywołująca usunięcie rekordu po kliknięciu przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteActive_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayWholeTable();
        }
        /// <summary>
        /// Metoda wyświetlająca w datagridview całą tablicę
        /// </summary>
        private void DisplayWholeTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Guests", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewGuestList.DataSource = table;
        }
        /// <summary>
        /// Metoda która po kliknięciiu przycisku szukaj wyświetli poszukiwanych gości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Guests WHERE Name LIKE '{textBoxSearchName.Text}' OR Surname LIKE '{textBoxSearchSurname.Text}'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewGuestList.DataSource = table;
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z danymi z tabeli Cloaks, źródło:
        /// http://csharp.net-informations.com/dataset/dataset-combobox.htm
        /// </summary>
        private void BindCloaks()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT Id,Number FROM Cloaks;";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBoxCloaks.DataSource = dataSet.Tables[0];
                comboBoxCloaks.ValueMember = "Id";
                comboBoxCloaks.DisplayMember = "Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        /// <summary>
        /// Metoda powrotu do okna podstawowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
