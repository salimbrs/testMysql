using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace part2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=Sakila;Uid=root;Pwd=salim1990;");
        public Form1()
        {
            InitializeComponent();
        }

        private void amountQ_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT payment_id,Month(payment_date) AS relevant_month ,SUM(amount) AS total_amount " +
                    "FROM payment " +
                    "GROUP BY payment_id, relevant_month "  +
                    "HAVING relevant_month = 5 ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]; // Filtrelenmiş veriyi tabloya yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Hata: " + ex.Message);
            }
        }

        private void title_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT a.film_id,a.title,COUNT(b.actor_id) AS total_actor " +
                    "from film a " +
                    "INNER JOIN film_actor  b " +
                    "ON a.film_id = b.film_id " +
                    "GROUP BY a.film_id,a.title";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]; // Filtrelenmiş veriyi tabloya yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Hata: " + ex.Message);
            }
        }

        private void country_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT a.country_id,a.country,b.city_id,b.city   " +
                    "from country a " +
                    "INNER JOIN city  b " +
                    "ON a.country_id = b.country_id " +
                    "WHERE a.country_id > 11 ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0]; // Filtrelenmiş veriyi tabloya yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Hata: " + ex.Message);
            }
        }
    }
}
