namespace contact
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgContact = new System.Windows.Forms.DataGridView();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 20);
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(54, 20);
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.btnThem.Size = new System.Drawing.Size(66, 20);
            this.btnThem.Text = "Thêm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgContact);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(13, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 341);
            this.panel2.TabIndex = 1;
            // 
            // dtgContact
            // 
            this.dtgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dtgContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgContact.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtgContact.Location = new System.Drawing.Point(0, 24);
            this.dtgContact.MultiSelect = false;
            this.dtgContact.Name = "dtgContact";
            this.dtgContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContact.Size = new System.Drawing.Size(445, 313);
            this.dtgContact.TabIndex = 1;
            this.dtgContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContact_CellContentClick);
            // 
            // col
            // 
            this.col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col.HeaderText = "";
            this.col.Name = "col";
            this.col.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDHistoryLearning";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Period";
            this.Column2.HeaderText = "Phone";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(385, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 33);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTACTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::contact.Properties.Resources.iconfinder_icon_111_search_314478;
            this.pictureBox1.Location = new System.Drawing.Point(419, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmContact";
            this.Text = "Contact";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgContact;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

