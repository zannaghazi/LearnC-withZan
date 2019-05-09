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
            this.txtMode = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.tableControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 12);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(467, 537);
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
            // txtMode
            // 
            this.txtMode.Enabled = false;
            this.txtMode.Location = new System.Drawing.Point(71, 4);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(134, 20);
            this.txtMode.TabIndex = 0;
            this.txtMode.Text = "Script";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect...";
            this.btnConnect.UseVisualStyleBackColor = true;
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
            // txtDBName
            // 
            this.txtDBName.Enabled = false;
            this.txtDBName.Location = new System.Drawing.Point(71, 31);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(226, 20);
            this.txtDBName.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(71, 85);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(226, 20);
            this.txtTableName.TabIndex = 5;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table name";
            // 
            // cbDBType
            // 
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
            this.cbDBType.Text = "Select the DB Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DB Type";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(11, 120);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(137, 23);
            this.btnAddTable.TabIndex = 10;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
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
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(486, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 255);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableControl);
            this.Controls.Add(this.dataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.tableControl.ResumeLayout(false);
            this.tableControl.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}

