namespace BudgetApproval
{
    partial class frmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Ref = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lbl_path1 = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_path2 = new System.Windows.Forms.Label();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOutline = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtROI = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSubmit = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSubmit.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelSubmit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtROI);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPurpose);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtOutline);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnBrowse2);
            this.panel1.Controls.Add(this.lbl_path2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnBrowse1);
            this.panel1.Controls.Add(this.lbl_path1);
            this.panel1.Controls.Add(this.cmbCurrency);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbDept);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Ref);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 663);
            this.panel1.TabIndex = 2;
            // 
            // label_Ref
            // 
            this.label_Ref.AutoSize = true;
            this.label_Ref.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ref.Location = new System.Drawing.Point(143, 61);
            this.label_Ref.Name = "label_Ref";
            this.label_Ref.Size = new System.Drawing.Size(41, 15);
            this.label_Ref.TabIndex = 1;
            this.label_Ref.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "REFERENCE NUMBER : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "BUDGET PERIOD : ";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "APR-SEP",
            "OCT-MAR"});
            this.cmbPeriod.Location = new System.Drawing.Point(401, 53);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(171, 23);
            this.cmbPeriod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEPARTMENT HEAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "CURRENCY : ";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(135, 92);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(195, 23);
            this.cmbDept.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "QUOTATION :";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "PHP",
            "JPY",
            "USD"});
            this.cmbCurrency.Location = new System.Drawing.Point(167, 121);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(82, 23);
            this.cmbCurrency.TabIndex = 8;
            // 
            // lbl_path1
            // 
            this.lbl_path1.AutoSize = true;
            this.lbl_path1.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_path1.Location = new System.Drawing.Point(132, 163);
            this.lbl_path1.Name = "lbl_path1";
            this.lbl_path1.Size = new System.Drawing.Size(81, 16);
            this.lbl_path1.TabIndex = 9;
            this.lbl_path1.Text = "directory path...";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse1.Location = new System.Drawing.Point(135, 182);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(71, 24);
            this.btnBrowse1.TabIndex = 10;
            this.btnBrowse1.Text = "BROWSE";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "IMAGE";
            // 
            // lbl_path2
            // 
            this.lbl_path2.AutoSize = true;
            this.lbl_path2.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_path2.Location = new System.Drawing.Point(132, 228);
            this.lbl_path2.Name = "lbl_path2";
            this.lbl_path2.Size = new System.Drawing.Size(81, 16);
            this.lbl_path2.TabIndex = 12;
            this.lbl_path2.Text = "directory path...";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse2.Location = new System.Drawing.Point(135, 247);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(71, 24);
            this.btnBrowse2.TabIndex = 13;
            this.btnBrowse2.Text = "BROWSE";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "OUTLINE : ";
            // 
            // txtOutline
            // 
            this.txtOutline.Location = new System.Drawing.Point(2, 314);
            this.txtOutline.Multiline = true;
            this.txtOutline.Name = "txtOutline";
            this.txtOutline.Size = new System.Drawing.Size(247, 212);
            this.txtOutline.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "ROI";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(290, 314);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(247, 212);
            this.txtPurpose.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Purpose Merit of this Investment";
            // 
            // txtROI
            // 
            this.txtROI.Location = new System.Drawing.Point(106, 543);
            this.txtROI.Name = "txtROI";
            this.txtROI.Size = new System.Drawing.Size(143, 21);
            this.txtROI.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 51);
            this.panel2.TabIndex = 20;
            // 
            // panelSubmit
            // 
            this.panelSubmit.BackColor = System.Drawing.Color.Transparent;
            this.panelSubmit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSubmit.Controls.Add(this.btnSubmit);
            this.panelSubmit.Location = new System.Drawing.Point(0, 612);
            this.panelSubmit.Name = "panelSubmit";
            this.panelSubmit.Size = new System.Drawing.Size(92, 51);
            this.panelSubmit.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 47);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            this.btnSubmit.MouseHover += new System.EventHandler(this.btnSubmit_MouseHover);
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panel1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(584, 663);
            this.panelBackground.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "BUDGET APPROVAL FORM ";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(290, 185);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(282, 21);
            this.txtItem.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "ITEM NAME :";
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 663);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForm";
            this.Text = "Application Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmForm_FormClosed);
            this.Load += new System.EventHandler(this.frmForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubmit.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSubmit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtROI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOutline;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lbl_path2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Label lbl_path1;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Ref;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label7;
    }
}