namespace DBAdder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.tableControl = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.pnData = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShowTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.tableControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 44);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(467, 505);
            this.dataTable.TabIndex = 0;
            // 
            // tableControl
            // 
            this.tableControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableControl.Controls.Add(this.btnReset);
            this.tableControl.Controls.Add(this.btnAddCol);
            this.tableControl.Controls.Add(this.btnEditTable);
            this.tableControl.Controls.Add(this.btnAddTable);
            this.tableControl.Controls.Add(this.label4);
            this.tableControl.Controls.Add(this.cbDBType);
            this.tableControl.Controls.Add(this.label3);
            this.tableControl.Controls.Add(this.label2);
            this.tableControl.Controls.Add(this.txtTableName);
            this.tableControl.Controls.Add(this.txtDBName);
            this.tableControl.Controls.Add(this.label1);
            this.tableControl.Controls.Add(this.btnConnect);
            this.tableControl.Controls.Add(this.txtMode);
            this.tableControl.Location = new System.Drawing.Point(486, 12);
            this.tableControl.Name = "tableControl";
            this.tableControl.Size = new System.Drawing.Size(302, 182);
            this.tableControl.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(154, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Table";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddCol
            // 
            this.btnAddCol.Enabled = false;
            this.btnAddCol.Location = new System.Drawing.Point(11, 149);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(137, 23);
            this.btnAddCol.TabIndex = 12;
            this.btnAddCol.Text = "Add Column";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Enabled = false;
            this.btnEditTable.Location = new System.Drawing.Point(154, 120);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(137, 23);
            this.btnEditTable.TabIndex = 11;
            this.btnEditTable.Text = "Edit Table";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(11, 120);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(137, 23);
            this.btnAddTable.TabIndex = 10;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB Type";
            // 
            // cbDBType
            // 
            this.cbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Items.AddRange(new object[] {
            "Microsoft SQL Server (1998 - 2012)",
            "Microsoft SQL Server (2013 - now)",
            "MySQL",
            "PostgreSQL",
            "MongoDB",
            "Oracle"});
            this.cbDBType.Location = new System.Drawing.Point(71, 58);
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(226, 21);
            this.cbDBType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DB name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(71, 85);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(226, 20);
            this.txtTableName.TabIndex = 5;
            // 
            // txtDBName
            // 
            this.txtDBName.Enabled = false;
            this.txtDBName.Location = new System.Drawing.Point(71, 31);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(226, 20);
            this.txtDBName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mode";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect...";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(71, 4);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(134, 20);
            this.txtMode.TabIndex = 0;
            this.txtMode.Text = "Script";
            // 
            // pnData
            // 
            this.pnData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnData.Location = new System.Drawing.Point(486, 201);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(302, 348);
            this.pnData.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Table Name: ";
            // 
            // txtShowTable
            // 
            this.txtShowTable.AutoSize = true;
            this.txtShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTable.Location = new System.Drawing.Point(132, 16);
            this.txtShowTable.Name = "txtShowTable";
            this.txtShowTable.Size = new System.Drawing.Size(0, 20);
            this.txtShowTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.txtShowTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.tableControl);
            this.Controls.Add(this.dataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.tableControl.ResumeLayout(false);
            this.tableControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Panel tableControl;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtShowTable;
    }
}

