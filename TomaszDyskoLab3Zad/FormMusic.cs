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
    public partial class FormMusic : Form
    {
        /// <summary>
        /// Przyszłe połączenie do naszej bazy danych
        /// </summary>
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny w którym łączymy się do bazy danych i wyświetlamy zawatrość tabeli Muzyka
        /// </summary>
        public FormMusic()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
        }
        /// <summary>
        /// Metoda uruchamiana po kliknięciu przcisku która dodaje wartość do bazy danych i odświerza widok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMusic_Click(object sender, EventArgs e)
        {
            InsertData(connection,
                       textBoxName.Text.Trim(),
                       textBoxLink.Text.Trim());
            DisplayWholeTable();
        }
        /// <summary>
        /// Funkcja przekazująca dane do bazy używając parametrów oraz tranzakcji
        /// </summary>
        private void InsertData(SqlConnection connectionString, string name, string link)
        {

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"INSERT INTO Music(Name,LinkURL) VALUES (@Name, @Link);";
            command.Parameters.Add("@Name", SqlDbType.VarChar, 31).Value = name;
            command.Parameters.Add("@Link", SqlDbType.Text).Value = link;
            command.ExecuteNonQuery();
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
            if (dataGridViewMusic.SelectedRows.Count > 0)
            {
                ///Zmienna przechowująca index zaznaczonego rzędu
                int selectedIndex = dataGridViewMusic.SelectedRows[0].Index;
                ///Zmienna przechowująca potrzebny mi index gościa
                int rowId = int.Parse(dataGridViewMusic[0, selectedIndex].Value.ToString());
                ///Zmienna przchowująca zaputanie sql
                string sql = "DELETE FROM Music WHERE Id = @RowID";
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
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Music", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMusic.DataSource = table;
        }
        /// <summary>
        /// Metoda która po kliknięciiu przycisku szukaj wyświetli poszukiwanych gości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Music WHERE Name LIKE '{textBoxSearchName.Text}'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewMusic.DataSource = table;
        }
        /// <summary>
        /// Metoda powrotu do głównego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
