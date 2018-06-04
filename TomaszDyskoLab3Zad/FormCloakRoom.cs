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
    public partial class FormCloakRoom : Form
    {
        /// <summary>
        /// Przyszłe połączenie do naszej bazy danych
        /// </summary>
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny w którym łączymy się do bazy danych i wyświetlamy zawatrość tabeli goście
        /// </summary>
        public FormCloakRoom()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
            BindCloaks();
        }
        /// <summary>
            /// Metoda zamykająca okno
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda wyświetlająca w datagridview całą tablicę
        /// </summary>
        private void DisplayWholeTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM [GuestsWithCloaksNumbers]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewCloakroom.DataSource = table;
            //Wyłączam widoczność elementów z numerami porządkowymi, będą mi one potrzebne, ale nie chcę aby widział je użytkownik 
            dataGridViewCloakroom.Columns["CloakId"].Visible = false;
            dataGridViewCloakroom.Columns["GuestId"].Visible = false;
            dataGridViewCloakroom.Columns["ConnectionId"].Visible = false;
        }
        /// <summary>
        /// Kod usunięcia aktywnej komórki źródło:
        /// https://stackoverflow.com/questions/5539243/how-to-delete-a-selected-row-from-datagridview-and-database
        /// </summary>
        private void DeleteRecord()
        {
            if (dataGridViewCloakroom.SelectedRows.Count > 0 && dataGridViewCloakroom.SelectedCells.Count >= 3)
            {
                int selectedIndex = dataGridViewCloakroom.SelectedRows[0].Index;

                int rowId = int.Parse(dataGridViewCloakroom["ConnectionId", selectedIndex].Value.ToString());
                string sql = "DELETE FROM CloakGuest WHERE Id = @RowId";

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
        /// Kod usunięcia aktywnego rzędu z tablicy asocjacyjnej CloakGuest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteActiveNumber_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayWholeTable();
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
        /// Przycisk dodający połączenie do tabeli CloakGuest na podstawie zaznaczonego wiersza oraz comboboxa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNumberToActive_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCloakroom.SelectedRows.Count > 0 && dataGridViewCloakroom.SelectedCells.Count >= 3)
                {
                    int selectedIndex = dataGridViewCloakroom.SelectedRows[0].Index;

                    int cloakId = Int32.Parse(comboBoxCloaks.Text);
                    int guestId = int.Parse(dataGridViewCloakroom["GuestId", selectedIndex].Value.ToString());
                    string sql = "INSERT INTO CloakGuest(CloakId,GuestId) VALUES (@cloakId, @guestId)";

                    SqlCommand deleteRecord = new SqlCommand();
                    deleteRecord.Connection = connection;
                    deleteRecord.CommandType = CommandType.Text;
                    deleteRecord.CommandText = sql;
                    deleteRecord.Parameters.Add("@cloakId", SqlDbType.Int).Value = cloakId;
                    deleteRecord.Parameters.Add("@guestId", SqlDbType.Int).Value = guestId;
                    deleteRecord.Connection.Open();
                    deleteRecord.ExecuteNonQuery();
                    deleteRecord.Connection.Close();
                }
                else
                {
                    MessageBox.Show("Musisz coś zaznaczyć!");
                }
            }
            catch (Exception ex)
            {
                //Jeśli się nie udało to wyrzucam błędy
                MessageBox.Show(ex.Message);
            }
                DisplayWholeTable();
        }
    }
}
