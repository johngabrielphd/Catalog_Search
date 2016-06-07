namespace CatalogSearch
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
            this.grpBorder = new System.Windows.Forms.GroupBox();
            this.pnlResultsBorder = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblIdent = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.pnlSearchBorder = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch2 = new System.Windows.Forms.Panel();
            this.cmbSearch2 = new System.Windows.Forms.ComboBox();
            this.pnlAndOr2 = new System.Windows.Forms.Panel();
            this.rdoOr2 = new System.Windows.Forms.RadioButton();
            this.rdoAnd2 = new System.Windows.Forms.RadioButton();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.pnlAndOr1 = new System.Windows.Forms.Panel();
            this.rdoOr1 = new System.Windows.Forms.RadioButton();
            this.rdoAnd1 = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlSearch3 = new System.Windows.Forms.Panel();
            this.cmbSearch3 = new System.Windows.Forms.ComboBox();
            this.txtSearch3 = new System.Windows.Forms.TextBox();
            this.pnlSearch1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.cmbSearch1 = new System.Windows.Forms.ComboBox();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.grpBorder.SuspendLayout();
            this.pnlResultsBorder.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.pnlSearchBorder.SuspendLayout();
            this.pnlSearch2.SuspendLayout();
            this.pnlAndOr2.SuspendLayout();
            this.pnlAndOr1.SuspendLayout();
            this.pnlSearch3.SuspendLayout();
            this.pnlSearch1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBorder
            // 
            this.grpBorder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBorder.Controls.Add(this.pnlResultsBorder);
            this.grpBorder.Controls.Add(this.pnlSearchBorder);
            this.grpBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBorder.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorder.ForeColor = System.Drawing.Color.Blue;
            this.grpBorder.Location = new System.Drawing.Point(12, 12);
            this.grpBorder.Name = "grpBorder";
            this.grpBorder.Size = new System.Drawing.Size(484, 475);
            this.grpBorder.TabIndex = 0;
            this.grpBorder.TabStop = false;
            this.grpBorder.Text = "Catalog Search";
            // 
            // pnlResultsBorder
            // 
            this.pnlResultsBorder.BackColor = System.Drawing.SystemColors.Control;
            this.pnlResultsBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultsBorder.Controls.Add(this.btnClear);
            this.pnlResultsBorder.Controls.Add(this.lblDescrip);
            this.pnlResultsBorder.Controls.Add(this.lblIdent);
            this.pnlResultsBorder.Controls.Add(this.lblResults);
            this.pnlResultsBorder.Controls.Add(this.pnlResults);
            this.pnlResultsBorder.Controls.Add(this.txtResults);
            this.pnlResultsBorder.Location = new System.Drawing.Point(21, 198);
            this.pnlResultsBorder.Name = "pnlResultsBorder";
            this.pnlResultsBorder.Size = new System.Drawing.Size(444, 257);
            this.pnlResultsBorder.TabIndex = 14;
            this.pnlResultsBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResultsBorder_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(343, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(235, 35);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(81, 16);
            this.lblDescrip.TabIndex = 16;
            this.lblDescrip.Text = "Description";
            // 
            // lblIdent
            // 
            this.lblIdent.AutoSize = true;
            this.lblIdent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdent.Location = new System.Drawing.Point(38, 35);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(67, 16);
            this.lblIdent.TabIndex = 15;
            this.lblIdent.Text = "Identifier";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Blue;
            this.lblResults.Location = new System.Drawing.Point(152, 10);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(122, 17);
            this.lblResults.TabIndex = 14;
            this.lblResults.Text = "Search Results";
            // 
            // pnlResults
            // 
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.lstResults);
            this.pnlResults.Location = new System.Drawing.Point(16, 54);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(111, 163);
            this.pnlResults.TabIndex = 2;
            this.pnlResults.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlResults_Paint);
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstResults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(0, 0);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(109, 162);
            this.lstResults.TabIndex = 0;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // txtResults
            // 
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResults.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(135, 55);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(288, 162);
            this.txtResults.TabIndex = 1;
            // 
            // pnlSearchBorder
            // 
            this.pnlSearchBorder.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSearchBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchBorder.Controls.Add(this.btnSearch);
            this.pnlSearchBorder.Controls.Add(this.pnlSearch2);
            this.pnlSearchBorder.Controls.Add(this.pnlAndOr2);
            this.pnlSearchBorder.Controls.Add(this.txtSearch2);
            this.pnlSearchBorder.Controls.Add(this.pnlAndOr1);
            this.pnlSearchBorder.Controls.Add(this.lblSearch);
            this.pnlSearchBorder.Controls.Add(this.pnlSearch3);
            this.pnlSearchBorder.Controls.Add(this.txtSearch3);
            this.pnlSearchBorder.Controls.Add(this.pnlSearch1);
            this.pnlSearchBorder.Controls.Add(this.txtSearch1);
            this.pnlSearchBorder.Location = new System.Drawing.Point(21, 32);
            this.pnlSearchBorder.Name = "pnlSearchBorder";
            this.pnlSearchBorder.Size = new System.Drawing.Size(444, 147);
            this.pnlSearchBorder.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(343, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch2
            // 
            this.pnlSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch2.Controls.Add(this.cmbSearch2);
            this.pnlSearch2.Location = new System.Drawing.Point(168, 57);
            this.pnlSearch2.Name = "pnlSearch2";
            this.pnlSearch2.Size = new System.Drawing.Size(146, 23);
            this.pnlSearch2.TabIndex = 7;
            // 
            // cmbSearch2
            // 
            this.cmbSearch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearch2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch2.FormattingEnabled = true;
            this.cmbSearch2.Location = new System.Drawing.Point(0, 0);
            this.cmbSearch2.Name = "cmbSearch2";
            this.cmbSearch2.Size = new System.Drawing.Size(144, 24);
            this.cmbSearch2.TabIndex = 5;
            // 
            // pnlAndOr2
            // 
            this.pnlAndOr2.Controls.Add(this.rdoOr2);
            this.pnlAndOr2.Controls.Add(this.rdoAnd2);
            this.pnlAndOr2.Location = new System.Drawing.Point(319, 70);
            this.pnlAndOr2.Name = "pnlAndOr2";
            this.pnlAndOr2.Size = new System.Drawing.Size(103, 26);
            this.pnlAndOr2.TabIndex = 11;
            // 
            // rdoOr2
            // 
            this.rdoOr2.AutoSize = true;
            this.rdoOr2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOr2.ForeColor = System.Drawing.Color.Black;
            this.rdoOr2.Location = new System.Drawing.Point(87, 7);
            this.rdoOr2.Name = "rdoOr2";
            this.rdoOr2.Size = new System.Drawing.Size(14, 13);
            this.rdoOr2.TabIndex = 1;
            this.rdoOr2.UseVisualStyleBackColor = true;
            // 
            // rdoAnd2
            // 
            this.rdoAnd2.AutoSize = true;
            this.rdoAnd2.Checked = true;
            this.rdoAnd2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnd2.ForeColor = System.Drawing.Color.Black;
            this.rdoAnd2.Location = new System.Drawing.Point(3, 3);
            this.rdoAnd2.Name = "rdoAnd2";
            this.rdoAnd2.Size = new System.Drawing.Size(77, 20);
            this.rdoAnd2.TabIndex = 0;
            this.rdoAnd2.TabStop = true;
            this.rdoAnd2.Text = " And/Or";
            this.rdoAnd2.UseVisualStyleBackColor = true;
            // 
            // txtSearch2
            // 
            this.txtSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(16, 57);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(146, 23);
            this.txtSearch2.TabIndex = 3;
            // 
            // pnlAndOr1
            // 
            this.pnlAndOr1.Controls.Add(this.rdoOr1);
            this.pnlAndOr1.Controls.Add(this.rdoAnd1);
            this.pnlAndOr1.Location = new System.Drawing.Point(320, 41);
            this.pnlAndOr1.Name = "pnlAndOr1";
            this.pnlAndOr1.Size = new System.Drawing.Size(103, 26);
            this.pnlAndOr1.TabIndex = 9;
            // 
            // rdoOr1
            // 
            this.rdoOr1.AutoSize = true;
            this.rdoOr1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOr1.ForeColor = System.Drawing.Color.Black;
            this.rdoOr1.Location = new System.Drawing.Point(86, 7);
            this.rdoOr1.Name = "rdoOr1";
            this.rdoOr1.Size = new System.Drawing.Size(14, 13);
            this.rdoOr1.TabIndex = 1;
            this.rdoOr1.UseVisualStyleBackColor = true;
            // 
            // rdoAnd1
            // 
            this.rdoAnd1.AutoSize = true;
            this.rdoAnd1.Checked = true;
            this.rdoAnd1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnd1.ForeColor = System.Drawing.Color.Black;
            this.rdoAnd1.Location = new System.Drawing.Point(3, 3);
            this.rdoAnd1.Name = "rdoAnd1";
            this.rdoAnd1.Size = new System.Drawing.Size(77, 20);
            this.rdoAnd1.TabIndex = 0;
            this.rdoAnd1.TabStop = true;
            this.rdoAnd1.Text = " And/Or";
            this.rdoAnd1.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Blue;
            this.lblSearch.Location = new System.Drawing.Point(152, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(123, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Criteria";
            // 
            // pnlSearch3
            // 
            this.pnlSearch3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch3.Controls.Add(this.cmbSearch3);
            this.pnlSearch3.Location = new System.Drawing.Point(168, 86);
            this.pnlSearch3.Name = "pnlSearch3";
            this.pnlSearch3.Size = new System.Drawing.Size(146, 23);
            this.pnlSearch3.TabIndex = 7;
            // 
            // cmbSearch3
            // 
            this.cmbSearch3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearch3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch3.FormattingEnabled = true;
            this.cmbSearch3.Location = new System.Drawing.Point(0, 0);
            this.cmbSearch3.Name = "cmbSearch3";
            this.cmbSearch3.Size = new System.Drawing.Size(144, 24);
            this.cmbSearch3.TabIndex = 9;
            this.cmbSearch3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtSearch3
            // 
            this.txtSearch3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch3.Location = new System.Drawing.Point(16, 86);
            this.txtSearch3.Name = "txtSearch3";
            this.txtSearch3.Size = new System.Drawing.Size(146, 23);
            this.txtSearch3.TabIndex = 2;
            // 
            // pnlSearch1
            // 
            this.pnlSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch1.Controls.Add(this.panel1);
            this.pnlSearch1.Controls.Add(this.cmbSearch1);
            this.pnlSearch1.Location = new System.Drawing.Point(168, 28);
            this.pnlSearch1.Name = "pnlSearch1";
            this.pnlSearch1.Size = new System.Drawing.Size(146, 23);
            this.pnlSearch1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 23);
            this.panel1.TabIndex = 7;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(0, 0);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(144, 24);
            this.cmbSearch.TabIndex = 5;
            // 
            // cmbSearch1
            // 
            this.cmbSearch1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch1.FormattingEnabled = true;
            this.cmbSearch1.Location = new System.Drawing.Point(-1, -1);
            this.cmbSearch1.Name = "cmbSearch1";
            this.cmbSearch1.Size = new System.Drawing.Size(146, 24);
            this.cmbSearch1.TabIndex = 5;
            // 
            // txtSearch1
            // 
            this.txtSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch1.Location = new System.Drawing.Point(16, 28);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(146, 23);
            this.txtSearch1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 499);
            this.Controls.Add(this.grpBorder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBorder.ResumeLayout(false);
            this.pnlResultsBorder.ResumeLayout(false);
            this.pnlResultsBorder.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlSearchBorder.ResumeLayout(false);
            this.pnlSearchBorder.PerformLayout();
            this.pnlSearch2.ResumeLayout(false);
            this.pnlAndOr2.ResumeLayout(false);
            this.pnlAndOr2.PerformLayout();
            this.pnlAndOr1.ResumeLayout(false);
            this.pnlAndOr1.PerformLayout();
            this.pnlSearch3.ResumeLayout(false);
            this.pnlSearch1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBorder;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.TextBox txtSearch3;
        private System.Windows.Forms.ComboBox cmbSearch1;
        private System.Windows.Forms.Panel pnlSearch1;
        private System.Windows.Forms.ComboBox cmbSearch3;
        private System.Windows.Forms.Panel pnlSearch3;
        private System.Windows.Forms.Panel pnlSearch2;
        private System.Windows.Forms.ComboBox cmbSearch2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAndOr1;
        private System.Windows.Forms.RadioButton rdoOr1;
        private System.Windows.Forms.RadioButton rdoAnd1;
        private System.Windows.Forms.Panel pnlAndOr2;
        private System.Windows.Forms.RadioButton rdoOr2;
        private System.Windows.Forms.RadioButton rdoAnd2;
        private System.Windows.Forms.Panel pnlSearchBorder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlResultsBorder;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblIdent;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnClear;
    }
}

