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

            MessageBox.Show("adatok rögzítése megtö9rtént!");
        }
    }
}
