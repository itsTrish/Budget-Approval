namespace BudgetApproval
{
    partial class FrmApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApplications));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelCriteria = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_txtSearch = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.panel_dgv = new System.Windows.Forms.Panel();
            this.panel_budget = new System.Windows.Forms.Panel();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.column_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_refID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_dateFiled = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_quotation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_img = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_btnClear = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel_btnUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel_btnAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_supplier = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_totalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackground.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_txtSearch.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.panel_dgv.SuspendLayout();
            this.panel_budget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_btnClear.SuspendLayout();
            this.panel_btnUpdate.SuspendLayout();
            this.panel_btnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panel_dgv);
            this.panelBackground.Controls.Add(this.panel_details);
            this.panelBackground.Controls.Add(this.panelCriteria);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1273, 824);
            this.panelBackground.TabIndex = 0;
            // 
            // panelCriteria
            // 
            this.panelCriteria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCriteria.Controls.Add(this.btnSearch);
            this.panelCriteria.Controls.Add(this.panel_txtSearch);
            this.panelCriteria.Controls.Add(this.panel1);
            this.panelCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCriteria.Location = new System.Drawing.Point(0, 0);
            this.panelCriteria.Name = "panelCriteria";
            this.panelCriteria.Size = new System.Drawing.Size(1273, 26);
            this.panelCriteria.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 22);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword :  ";
            // 
            // panel_txtSearch
            // 
            this.panel_txtSearch.Controls.Add(this.textBox1);
            this.panel_txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_txtSearch.Location = new System.Drawing.Point(77, 0);
            this.panel_txtSearch.Name = "panel_txtSearch";
            this.panel_txtSearch.Size = new System.Drawing.Size(224, 22);
            this.panel_txtSearch.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 21);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(153)))), ((int)(((byte)(200)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(301, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.panel3);
            this.panel_details.Controls.Add(this.panel2);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 450);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(1273, 374);
            this.panel_details.TabIndex = 3;
            // 
            // panel_dgv
            // 
            this.panel_dgv.Controls.Add(this.dgvItems);
            this.panel_dgv.Controls.Add(this.panel_budget);
            this.panel_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_dgv.Location = new System.Drawing.Point(0, 26);
            this.panel_dgv.Name = "panel_dgv";
            this.panel_dgv.Size = new System.Drawing.Size(1273, 426);
            this.panel_dgv.TabIndex = 0;
            // 
            // panel_budget
            // 
            this.panel_budget.Controls.Add(this.dgvApplications);
            this.panel_budget.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_budget.Location = new System.Drawing.Point(0, 0);
            this.panel_budget.Name = "panel_budget";
            this.panel_budget.Size = new System.Drawing.Size(626, 426);
            this.panel_budget.TabIndex = 0;
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ref,
            this.column_status,
            this.column_date,
            this.Column5,
            this.column_totalAmt});
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplications.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvApplications.Location = new System.Drawing.Point(0, 0);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(626, 426);
            this.dgvApplications.TabIndex = 0;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_item,
            this.column_description,
            this.column_qty,
            this.column_amount,
            this.column_total});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(626, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(647, 426);
            this.dgvItems.TabIndex = 1;
            // 
            // column_item
            // 
            this.column_item.HeaderText = "Item";
            this.column_item.Name = "column_item";
            this.column_item.ReadOnly = true;
            // 
            // column_description
            // 
            this.column_description.HeaderText = "Description";
            this.column_description.Name = "column_description";
            this.column_description.ReadOnly = true;
            // 
            // column_qty
            // 
            this.column_qty.HeaderText = "Quantity";
            this.column_qty.Name = "column_qty";
            this.column_qty.ReadOnly = true;
            // 
            // column_amount
            // 
            this.column_amount.HeaderText = "Amount";
            this.column_amount.Name = "column_amount";
            this.column_amount.ReadOnly = true;
            // 
            // column_total
            // 
            this.column_total.HeaderText = "Total";
            this.column_total.Name = "column_total";
            this.column_total.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label_img);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label_quotation);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_supplier);
            this.panel2.Controls.Add(this.label_dateFiled);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_refID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 374);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(626, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 374);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reference # : ";
            // 
            // label_refID
            // 
            this.label_refID.AutoSize = true;
            this.label_refID.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_refID.Location = new System.Drawing.Point(87, 16);
            this.label_refID.Name = "label_refID";
            this.label_refID.Size = new System.Drawing.Size(52, 16);
            this.label_refID.TabIndex = 1;
            this.label_refID.Text = "(insert id)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Filed :  ";
            // 
            // label_dateFiled
            // 
            this.label_dateFiled.AutoSize = true;
            this.label_dateFiled.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateFiled.Location = new System.Drawing.Point(279, 16);
            this.label_dateFiled.Name = "label_dateFiled";
            this.label_dateFiled.Size = new System.Drawing.Size(62, 16);
            this.label_dateFiled.TabIndex = 3;
            this.label_dateFiled.Text = "(insert date)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quotation : ";
            // 
            // label_quotation
            // 
            this.label_quotation.AutoSize = true;
            this.label_quotation.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quotation.Location = new System.Drawing.Point(87, 41);
            this.label_quotation.Name = "label_quotation";
            this.label_quotation.Size = new System.Drawing.Size(52, 16);
            this.label_quotation.TabIndex = 5;
            this.label_quotation.Text = "(insert id)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Images :";
            // 
            // label_img
            // 
            this.label_img.AutoSize = true;
            this.label_img.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_img.Location = new System.Drawing.Point(279, 41);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(61, 16);
            this.label_img.TabIndex = 7;
            this.label_img.Text = "(insert img)";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 287);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel_btnAdd);
            this.panel5.Controls.Add(this.panel_btnUpdate);
            this.panel5.Controls.Add(this.panel_btnClear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(545, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 287);
            this.panel5.TabIndex = 4;
            // 
            // panel_btnClear
            // 
            this.panel_btnClear.Controls.Add(this.btnClear);
            this.panel_btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btnClear.Location = new System.Drawing.Point(0, 236);
            this.panel_btnClear.Name = "panel_btnClear";
            this.panel_btnClear.Size = new System.Drawing.Size(77, 51);
            this.panel_btnClear.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 41);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear\r\nSelection";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel_btnUpdate
            // 
            this.panel_btnUpdate.Controls.Add(this.btnUpdate);
            this.panel_btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btnUpdate.Location = new System.Drawing.Point(0, 194);
            this.panel_btnUpdate.Name = "panel_btnUpdate";
            this.panel_btnUpdate.Size = new System.Drawing.Size(77, 42);
            this.panel_btnUpdate.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel_btnAdd
            // 
            this.panel_btnAdd.Controls.Add(this.btnAdd);
            this.panel_btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btnAdd.Location = new System.Drawing.Point(0, 152);
            this.panel_btnAdd.Name = "panel_btnAdd";
            this.panel_btnAdd.Size = new System.Drawing.Size(77, 42);
            this.panel_btnAdd.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Supplier : ";
            // 
            // label_supplier
            // 
            this.label_supplier.AutoSize = true;
            this.label_supplier.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supplier.Location = new System.Drawing.Point(457, 16);
            this.label_supplier.Name = "label_supplier";
            this.label_supplier.Size = new System.Drawing.Size(81, 16);
            this.label_supplier.TabIndex = 3;
            this.label_supplier.Text = "(insert supplier)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Approvers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 287);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Approver";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date of Remark";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // column_ref
            // 
            this.column_ref.HeaderText = "Ref ID";
            this.column_ref.Name = "column_ref";
            this.column_ref.ReadOnly = true;
            // 
            // column_status
            // 
            this.column_status.HeaderText = "Status";
            this.column_status.Name = "column_status";
            this.column_status.ReadOnly = true;
            // 
            // column_date
            // 
            this.column_date.HeaderText = "Date";
            this.column_date.Name = "column_date";
            this.column_date.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // column_totalAmt
            // 
            this.column_totalAmt.HeaderText = "Total";
            this.column_totalAmt.Name = "column_totalAmt";
            this.column_totalAmt.ReadOnly = true;
            // 
            // FrmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1273, 824);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApplications";
            this.Text = "FrmApplications";
            this.Load += new System.EventHandler(this.FrmApplications_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelCriteria.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_txtSearch.ResumeLayout(false);
            this.panel_txtSearch.PerformLayout();
            this.panel_details.ResumeLayout(false);
            this.panel_dgv.ResumeLayout(false);
            this.panel_budget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_btnClear.ResumeLayout(false);
            this.panel_btnUpdate.ResumeLayout(false);
            this.panel_btnAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelCriteria;
        private System.Windows.Forms.Panel panel_txtSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel_dgv;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panel_budget;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_quotation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_dateFiled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_refID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_btnClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel_btnAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel_btnUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label_supplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_totalAmt;
    }
}