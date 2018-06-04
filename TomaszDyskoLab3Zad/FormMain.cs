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
    public partial class FormMain : Form
    {
        SqlConnection connection;
        /// <summary>
        /// Konstruktor domyślny FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source =TOMEK-KOMPUTER\LOL; database=WorkHelper; Trusted_Connection = yes");
            BindMusic();
        }
        /// <summary>
        /// Metoda otwierająca okno zarządzania listą gości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuests_Click(object sender, EventArgs e)
        {
            FormGuestList formGuestList = new FormGuestList();
            formGuestList.Show();
        }
        /// <summary>
        ///  Metoda otwierająca okno zarządzania szatnią
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloakroom_Click(object sender, EventArgs e)
        {
            FormCloakRoom formCloakRoom = new FormCloakRoom();
            formCloakRoom.Show();
        }
        /// <summary>
        ///  Metoda otwierająca okno zarządzania menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
        /// <summary>
        ///  Metoda otwierająca okno zarządzania stolikami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTabels_Click(object sender, EventArgs e)
        {
            FormTabels formTables = new FormTabels();
            formTables.Show();
        }
        /// <summary>
        ///  Metoda otwierająca okno zarządzania muzyką
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMusic_Click(object sender, EventArgs e)
        {
            FormMusic formMusic = new FormMusic();
            formMusic.Show();
        }
        /// <summary>
        ///  Metoda otwierająca okno zarządzania zamówieniami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }
        /// <summary>
        /// Metoda wiążąca comboBoxa z danymi z tabeli Music, źródło:
        /// http://csharp.net-informations.com/dataset/dataset-combobox.htm
        /// </summary>
        private void BindMusic()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string sql = "SELECT LinkURL,Name FROM Music;";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBoxMusic.DataSource = dataSet.Tables[0];
                comboBoxMusic.ValueMember = "LinkURL";
                comboBoxMusic.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        /// <summary>
        /// Po zmianie nazwy muzyki zmienia url filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowserMusic.Navigate(comboBoxMusic.SelectedValue.ToString());
        }

        /// <summary>
        /// funkcja odświerzenia Comboboxa
        /// </summary>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            BindMusic();
        }
    }
}
