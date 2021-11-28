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
    public partial class FrmElad : Form
    {
        string connString;
        public FrmElad(string connString)
        {
            this.connString = connString;
            InitializeComponent();
        }

        private void FrmElad_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connString);

            connection.Open();

            var command = new SqlCommand("SELECT nev FROM zoldseg;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) cbTermekek.Items.Add(reader[0]);

            connection.Close();

            cbTermekek.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var datum = dtpEladdatum.Value.ToString("yyyy-MM-dd");
            var termek = cbTermekek.SelectedIndex + 1;
            var db = tbMennyiseg.Text;

            var connection = new SqlConnection(connString);

            try
            {
                var errMessage = "";
                if (!int.TryParse(tbMennyiseg.Text, out _)) errMessage += "Az eladott mennyiség csak szám lehet!";
                if (String.IsNullOrWhiteSpace(tbMennyiseg.Text)) errMessage += "Az eladott mennyiség mező nem maradhat üresen!";

                if (!String.IsNullOrEmpty(errMessage)) throw new Exception(errMessage);

                connection.Open();
                var command = new SqlCommand($"INSERT INTO eladas VALUES ('{datum}', '{termek}', '{db}');",connection);
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
            this.Dispose();
        }
    }
}
