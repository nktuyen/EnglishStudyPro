using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESPA
{
    public partial class frmDBSelection : Form
    {
        private ESPDatabase DB { get; set; }
        public frmDBSelection()
        {
            InitializeComponent();
            DB = null;
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            StringBuilder connStr = new StringBuilder($"data source={cbServer.Text};initial catalog={txtDBName.Text};Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework;User Id={txtUsername.Text};Password={txtPassword.Text};Persist Security Info=True");

            ESPDatabase database = null;
            DialogResult res = DialogResult.OK;
            try
            {
                database = new ESPDatabase(connStr.ToString());
                if (null == database.Database.Connection)
                {
                    res = MessageBox.Show("Cannot connect to database.", "Database connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (database.Database.Connection.State != ConnectionState.Open)
                {
                    if (!database.Database.Exists())
                    { 
                        res = MessageBox.Show("Cannot connect to database.", "Database connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                res = MessageBox.Show(ex.Message, "Database connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DB = database;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled =
                (cbServer.Text != string.Empty
                && txtDBName.Text != string.Empty
                && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled =
                (cbServer.Text != string.Empty
                && txtDBName.Text != string.Empty
                && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled =
                (cbServer.Text != string.Empty
                && txtDBName.Text != string.Empty
                && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty);
        }

        private void frmDBSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                (new frmMain(DB)).ShowDialog();
            }
        }

        private void cbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled =
                (cbServer.Text != string.Empty
                && txtDBName.Text != string.Empty
                && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty);
        }

        private void cbServer_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled =
                (cbServer.Text != string.Empty
                && txtDBName.Text != string.Empty
                && txtUsername.Text != string.Empty
                && txtPassword.Text != string.Empty);
        }

        private void frmDBSelection_Load(object sender, EventArgs e)
        {
            cbServer.Items.Add("(local)");
            cbServer.Items.Add(Environment.MachineName);
            cbServer.SelectedIndex = 0;
            cbServer_SelectedIndexChanged(cbServer, new EventArgs());
        }
    }
}
