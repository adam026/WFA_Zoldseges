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

namespace WFAzoldseges
{
    public partial class FrmUjTermek : Form
    {
        string connString;
        public FrmUjTermek(string connString)
        {
            this.connString = connString;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string egysegar = tbEgysegar.Text;
            var connection = new SqlConnection(connString);

            try
            {
                string errorMessage = "";

                if (String.IsNullOrWhiteSpace(nev)) errorMessage += "A név mező nem lehet üres!";
                if (String.IsNullOrWhiteSpace(egysegar)) errorMessage += "Az egységár mező nem lehet üres!";
                if (!int.TryParse(tbEgysegar.Text, out _)) errorMessage += "Az egységárnak egész számnak kell lennie!";

                if (!String.IsNullOrEmpty(errorMessage))
                {
                    throw new Exception(errorMessage);
                }

                connection.Open();

                var command = new SqlCommand(
                    "INSERT INTO zoldseg VALUES " +
                    $"('{nev}', '{egysegar}');", connection);
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = command,
                };

                adapter.InsertCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            var connection1 = new SqlConnection(connString);
            connection1.Open();
            var command1 = new SqlCommand("SELECT * FROM zoldseg;", connection1);
            var reader = command1.ExecuteReader();

            while (reader.Read()) 
            {
                tbId.Text = reader[0].ToString();
                tbNev.Text = reader[1].ToString();
                tbEgysegar.Text = reader[2].ToString();
            }

            connection1.Close();
        }
    }
}
