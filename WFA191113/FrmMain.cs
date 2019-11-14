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

namespace WFA191113
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            InitializeComponent();
            conn = new SqlConnection(@"SERVER=(localdb)\MSSQLLocalDB;DATABASE=naplo;");
            FillRtb();
        }

        private void FillRtb()
        {
            rtbJegyek.Clear();
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM jegyek;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                rtbJegyek.Text += string.Format(
                    "{0, -18}   {1,9}   {2, 19}   {3}   {4}\n",
                    r[1],
                    r.GetDateTime(2).ToString("MMM dd"),
                    r[3],
                    r.GetBoolean(4) ? "TZ" : "  ", 
                    r[5]);

                dgvJegyek.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5]);
            }
            conn.Close();
        }

        private void btnUjJegy_Click(object sender, EventArgs e)
        {
            conn.Open();

            var adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO jegyek (nev, datum, tema, tz, jegy) " +
                $"VALUES ('{tbNev.Text}', '{dtpDatum.Value.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                $"'{tbTema.Text}', {(cbTz.Checked ? 1 : 0)}, {nudJegy.Value});", conn);
            
            adapter.InsertCommand.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("adatok rögzítése megtörtént!");
            FillRtb();
        }

        private void dgvJegyek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvJegyek[e.ColumnIndex, e.RowIndex].Value.ToString());
        }
    }
}
