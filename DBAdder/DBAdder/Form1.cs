using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAdder.Dialog;

namespace DBAdder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int colIndex = 0;
        private string tableName = "";
        private string sessionTableName = "";
        private int sesstionDBType = -1;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBConnection dbInfoDialog = new DBConnection();
            dbInfoDialog.ShowDialog();
            DBInfo dbInfo = dbInfoDialog.dataInfo;
            if (dbInfoDialog.isEdited)
            { 
                this.txtDBName.Text = dbInfo.DBName;
                this.txtMode.Text = "DB Connection";
                if (dbInfo.dataType == "")
                {
                    this.cbDBType.SelectedItem = null;
                    this.cbDBType.Enabled = true;
                }
                else
                {
                    if (dbInfo.dataType == "Microsoft SQL Server")
                    {
                        this.cbDBType.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cbDBType.SelectedIndex = 3; // PostgreSQL
                    }
                    this.cbDBType.Enabled = false;
                }
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (this.cbDBType.SelectedItem == null)
            {
                MessageBox.Show("Database type is required!");
                return;
            }
            if (String.IsNullOrWhiteSpace(this.txtTableName.Text))
            {
                MessageBox.Show("Table name is required!");
                return;
            }
            this.txtShowTable.Text = this.txtTableName.Text;
            this.tableName = this.txtTableName.Text;
            //this.dataTable.Columns.Add("col" + this.colIndex, tableName);
            //this.colIndex++;

            //Disable all table info
            this.btnConnect.Enabled = false;
            this.txtTableName.Enabled = false;
            this.btnAddTable.Enabled = false;
            this.cbDBType.Enabled = false;

            // Enable all table content
            this.btnEditTable.Enabled = true;
            this.btnAddCol.Enabled = true;
            this.btnReset.Enabled = true;

            if (this.btnAddTable.Text == "OK")
            {
                this.btnAddTable.Text = "Add Table";
                this.btnEditTable.Text = "Edit Table";
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            if (this.btnEditTable.Text == "Edit Table")
            {
                this.sessionTableName = this.txtTableName.Text;
                this.sesstionDBType = this.cbDBType.SelectedIndex;
                // Enable all table info
                this.txtTableName.Enabled = true;
                this.btnAddTable.Enabled = true;
                this.btnAddTable.Text = "OK";
                if (String.IsNullOrWhiteSpace(this.txtDBName.Text))
                {
                    this.cbDBType.Enabled = true;
                }
                
                // Disable all table content
                this.btnEditTable.Enabled = true;
                this.btnAddCol.Enabled = false;
                this.btnReset.Enabled = false;

                this.btnEditTable.Text = "Cancel";
            }
            else
            {
                this.txtTableName.Text = this.sessionTableName;
                this.cbDBType.SelectedIndex = this.sesstionDBType;
                //Disable all table info
                this.btnConnect.Enabled = false;
                this.txtTableName.Enabled = false;
                this.btnAddTable.Enabled = false;
                this.cbDBType.Enabled = false;

                // Enable all table content
                this.btnEditTable.Enabled = true;
                this.btnAddCol.Enabled = true;
                this.btnReset.Enabled = true;

                this.btnAddTable.Text = "Add Table";
                this.btnEditTable.Text = "Edit Table";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtShowTable.Text = "";
            this.dataTable = new DataGridView();
            this.txtMode.Text = "Script";
            this.btnConnect.Enabled = true;
            this.txtDBName.Text = "";
            this.cbDBType.SelectedItem = "";
            this.txtTableName.Text = "";
            this.btnAddTable.Enabled = true;
            this.btnEditTable.Enabled = false;
            this.btnAddCol.Enabled = false;
            this.btnReset.Enabled = false;

            this.colIndex = 0;
            this.tableName = "";
            this.sessionTableName = "";
            this.sesstionDBType = -1;
    }

        private void btnAddCol_Click(object sender, EventArgs e)
        {

        }
    }
}
