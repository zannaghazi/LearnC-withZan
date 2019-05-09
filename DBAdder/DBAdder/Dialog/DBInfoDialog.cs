using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAdder.Dialog
{
    public partial class DBConnection : Form
    {
        public DBInfo dataInfo = new DBInfo();
        public bool isEdited = false;

        public DBConnection()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username is required!");
                return;
            }
            if (String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required!");
                return;
            }
            if (String.IsNullOrWhiteSpace(this.txtDBName.Text))
            {
                MessageBox.Show("Database name is required!");
                return;
            }

            if (String.IsNullOrWhiteSpace(this.txtServerName.Text) || this.cbDBType.Text == "Select the database type")
            {
                DialogResult selection = MessageBox.Show(this,
                    "Data system default will be Microsoft SQL Server.\nDo you want to continues?",
                    "Confirm default data system",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (selection == DialogResult.Yes)
                {
                    this.isEdited = true;
                    this.dataInfo = new DBInfo(
                        this.txtUsername.Text,
                        this.txtPassword.Text,
                        this.txtDBName.Text);
                    this.Close();
                }else
                {
                    return;
                }
            }else
            {
                this.isEdited = true;
                this.dataInfo = new DBInfo(
                    this.txtServerName.Text,
                    this.cbDBType.Text,
                    this.txtUsername.Text,
                    this.txtPassword.Text,
                    this.txtDBName.Text);
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.isEdited = true;
            this.dataInfo = new DBInfo();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.isEdited = false;
            this.Close();
        }
    }
}
