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
    public partial class FormOrders : Form
    {
        /// <summary>
        /// Przyszłe połączenie do naszej bazy danych
        /// </summary>
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny w którym łączymy się do bazy danych i wyświetlamy zawatrość tabeli Muzyka
        /// </summary>
        public FormOrders()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            DisplayWholeTable();
            BindProducts();
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
        /// <summary>
        /// Metoda wyświetlająca w datagridview całą tablicę
        /// </summary>
        private void DisplayWholeTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM [OrdersWithProducts]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewOrders.DataSource = table;
            //Wyłączam widoczność elementów z numerami porządkowymi, będą mi one potrzebne, ale nie chcę aby widział je użytkownik 
            dataGridViewOrders.Columns["MenuId"].Visible = false;
            dataGridViewOrders.Columns["BillId"].Visible = false;
            dataGridViewOrders.Columns["ConnectionId"].Visible = false;
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z danymi z tabeli Cloaks, źródło:
        /// http://csharp.net-informations.com/dataset/dataset-combobox.htm
        /// </summary>
        private void BindProducts()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT Id,Name FROM Menu;";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBoxProducts.DataSource = dataSet.Tables[0];
                comboBoxProducts.ValueMember = "Id";
                comboBoxProducts.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        /// <summary>
        /// Kod usunięcia aktywnego wiersza, źródło:
        /// https://stackoverflow.com/questions/5539243/how-to-delete-a-selected-row-from-datagridview-and-database
        /// </summary>
        private void DeleteRecord()
        {
            if (dataGridViewOrders.SelectedRows.Count > 0 && dataGridViewOrders.SelectedCells.Count >= 3)
            {
                int selectedIndex = dataGridViewOrders.SelectedRows[0].Index;

                int rowId = int.Parse(dataGridViewOrders["ConnectionId", selectedIndex].Value.ToString());
                string sql = "DELETE FROM Orders WHERE Id = @RowId";

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
        /// Metoda która po kliknięciu przycisku usuwa aktywny wiersz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteActive_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            DisplayWholeTable();
        }
        /// <summary>
        /// Przycisk dodający połączenie do tabeli Orders na podstawie zaznaczonego wiersza oraz comboboxa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InsertData(connection, Int32.Parse(textBoxNumber.Text));
            DisplayWholeTable();
        }
        /// <summary>
        /// Funkcja przekazująca dane do bazy używając parametrów oraz tranzakcji
        /// </summary>
        private void InsertData(SqlConnection connectionString, int billNumber)
        {

            connection.Open();
            int menuItemId = Int32.Parse(comboBoxProducts.SelectedValue.ToString());
            MessageBox.Show(menuItemId.ToString());
            //Deklaruję nową tranzakcję oraz zapytanie sql
            SqlTransaction sqlTransaction = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Transaction = sqlTransaction;
            command.Connection = connection;
            //Sprawdzam czy jest możliwe wykonanie tej operacji, jeśli jest to wykonuję a jeśli nie to wykonuję RollBack i o błędzie informuję w messageboxie
            try
            {
                command.CommandText = $"INSERT INTO Bills(BillNumber) VALUES (@Number);";
                command.Parameters.Add("@Number", SqlDbType.VarChar, 31).Value = billNumber;
                command.ExecuteNonQuery();
                command.CommandText = $"INSERT INTO Orders(BillId, MenuItemId) Values(IDENT_CURRENT('Bills') , @MenuItemId)";
                command.Parameters.Add("@MenuItemId", SqlDbType.Int).Value = menuItemId;
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
    }
}
