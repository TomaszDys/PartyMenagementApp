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
    public partial class FormMenu : Form
    {
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny w którym łączymy się do bazy danych i wyświetlamy zawatrość tabeli goście
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
        }
        /// <summary>
        /// Funcja zmieniająca tekst z textboxa na format walutowy 
        /// źródło: https://stackoverflow.com/questions/19215989/textbox-for-price-cash-currency-on-c-sharp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPize_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(textBoxPrize.Text, out value))
                textBoxPrize.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                textBoxPrize.Text = String.Empty;
        }
        /// <summary>
        /// Metoda dodająca produkt do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            InsertData(connection, textBoxName.Text, Decimal.Parse(textBoxPrize.Text), textBoxAmount.Text);
            DisplayWholeTable();
        }
        /// <summary>
        /// Funkcja przekazująca dane do bazy używając parametrów oraz tranzakcji
        /// </summary>
        private void InsertData(SqlConnection connectionString, string name, Decimal prize, string amount)
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
                command.CommandText = $"INSERT INTO Menu(Name,Prize,Amount) VALUES (@Name, @Prize,@Amount);";
                command.Parameters.Add("@Name", SqlDbType.VarChar, 31).Value = name;
                command.Parameters.Add("@Prize", SqlDbType.SmallMoney, 31).Value = prize;
                command.Parameters.Add("@Amount", SqlDbType.VarChar, 31).Value = amount;
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
        /// Metoda wyświetlająca w datagridview całą tablicę
        /// </summary>
        private void DisplayWholeTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Menu", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMenu.DataSource = table;
        }
        /// <summary>
        /// Metoda zamknięcia okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda która po kliknięciiu przycisku szukaj wyświetli poszukiwany produkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Menu WHERE Name LIKE '{textBoxSearchName.Text}'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMenu.DataSource = table;
        }
        /// <summary>
        /// Kod usunięcia aktywnej komórki źródło:
        /// https://stackoverflow.com/questions/5539243/how-to-delete-a-selected-row-from-datagridview-and-database
        /// </summary>
        private void DeleteRecord()
        {
            if (dataGridViewMenu.SelectedRows.Count > 0 && dataGridViewMenu.SelectedCells.Count >= 3)
            {
                ///Zmienna przechowująca index zaznaczonego rzędu
                int selectedIndex = dataGridViewMenu.SelectedRows[0].Index;
                ///Zmienna przechowująca potrzebny mi index gościa
                int rowId = int.Parse(dataGridViewMenu[0, selectedIndex].Value.ToString());
                ///Zmienna przchowująca zaputanie sql
                string sql = "DELETE FROM Menu WHERE Id = @RowID";
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
            else
            {
                MessageBox.Show("Musisz coś zaznaczyć!");
            }
        }
        /// <summary>
        /// Metoda usuwająca aktywny wiersz po kliknięciu przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteActive_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayWholeTable();
        }
        /// <summary>
        /// Metoda resetująca widok po kliknięciu przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            DisplayWholeTable();
        }
    }
}
