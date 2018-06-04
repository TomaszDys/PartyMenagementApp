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
    public partial class FormTabels : Form
    {
        /// <summary>
        /// Przyszłe połączenie do naszej bazy danych
        /// </summary>
        SqlConnection connection;
        public FormTabels()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
            BindTables();
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
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM [GuestsWithTables]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewTables.DataSource = table;
            //Wyłączam widoczność elementów z numerami porządkowymi, będą mi one potrzebne, ale nie chcę aby widział je użytkownik 
            dataGridViewTables.Columns["GuestId"].Visible = false;
            dataGridViewTables.Columns["ConnectionId"].Visible = false;
        }
        /// <summary>
        /// Kod usunięcia aktywnej komórki źródło:
        /// https://stackoverflow.com/questions/5539243/how-to-delete-a-selected-row-from-datagridview-and-database
        /// </summary>
        private void DeleteRecord()
        {
            if (dataGridViewTables.SelectedRows.Count > 0 && dataGridViewTables.SelectedCells.Count >= 3)
            {
                int selectedIndex = dataGridViewTables.SelectedRows[0].Index;

                int rowId = int.Parse(dataGridViewTables["ConnectionId", selectedIndex].Value.ToString());
                string sql = "DELETE FROM GuestTable WHERE Id = @RowId";

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
        /// Kod usunięcia aktywnego rzędu z tablicy asocjacyjnej 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteActiveNumber_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayWholeTable();
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z danymi z tabeli  źródło:
        /// http://csharp.net-informations.com/dataset/dataset-combobox.htm
        /// </summary>
        private void BindTables()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT Id FROM Tabels;";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBoxTables.DataSource = dataSet.Tables[0];
                comboBoxTables.ValueMember = "Id";
                comboBoxTables.DisplayMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        /// <summary>
        /// Przycisk dodający połączenie do tabeli TableGuest na podstawie zaznaczonego wiersza oraz comboboxa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNumberToActive_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0 && dataGridViewTables.SelectedCells.Count >= 3)
            {
                int selectedIndex = dataGridViewTables.SelectedRows[0].Index;

                int tableId = Int32.Parse(comboBoxTables.Text);
                int guestId = int.Parse(dataGridViewTables["GuestId", selectedIndex].Value.ToString());
                string sql = "INSERT INTO GuestTable(GuestId,TableId) VALUES (@guestId, @tableId)";

                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = connection;
                deleteRecord.CommandType = CommandType.Text;
                deleteRecord.CommandText = sql;
                deleteRecord.Parameters.Add("@guestId", SqlDbType.Int).Value = guestId;
                deleteRecord.Parameters.Add("@tableId", SqlDbType.Int).Value = tableId;
                deleteRecord.Connection.Open();
                deleteRecord.ExecuteNonQuery();
                deleteRecord.Connection.Close();
            }
            else
            {
                MessageBox.Show("Musisz coś zaznaczyć!");
            }
            DisplayWholeTable();
        }
    }
}
