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
    public partial class FrmMain : Form
    {
        public string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=zoldseges1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) => UpdateDGV();

        public void UpdateDGV()
        {
            dgvMain.Rows.Clear();
            var connection = new SqlConnection(connString);
            connection.Open();

            var command = new SqlCommand($"SELECT datum, nev, egysegAr * mennyiseg FROM zoldseg INNER JOIN eladas ON zoldseg.id = zoldsegid WHERE nev LIKE('{tbKereses.Text}%');", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                    reader[1],
                    reader[2] + " Ft");
            }

            connection.Close();
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjTermek(connString);
            frm.ShowDialog();
            UpdateDGV();
        }

        private void btnElad_Click(object sender, EventArgs e)
        {
            var frm = new FrmElad(connString);
            frm.ShowDialog();
            UpdateDGV();
        }

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }
    }
}
