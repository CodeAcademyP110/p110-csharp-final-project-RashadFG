namespace ColemanFitnessClub
{
    partial class Employees
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
            this.cmbservices = new System.Windows.Forms.ComboBox();
            this.cmbPacket = new System.Windows.Forms.ComboBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblPacket = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.lblPrices = new System.Windows.Forms.Label();
            this.lblServicesDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesPacketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCustoemrs = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbservices
            // 
            this.cmbservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbservices.FormattingEnabled = true;
            this.cmbservices.Location = new System.Drawing.Point(34, 61);
            this.cmbservices.Name = "cmbservices";
            this.cmbservices.Size = new System.Drawing.Size(242, 32);
            this.cmbservices.TabIndex = 6;
            this.cmbservices.SelectedIndexChanged += new System.EventHandler(this.cmbservices_SelectedIndexChanged);
            // 
            // cmbPacket
            // 
            this.cmbPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacket.FormattingEnabled = true;
            this.cmbPacket.Location = new System.Drawing.Point(34, 143);
            this.cmbPacket.Name = "cmbPacket";
            this.cmbPacket.Size = new System.Drawing.Size(242, 32);
            this.cmbPacket.TabIndex = 7;
            this.cmbPacket.SelectedIndexChanged += new System.EventHandler(this.cmbPacket_SelectedIndexChanged);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.BackColor = System.Drawing.Color.Transparent;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.ForeColor = System.Drawing.Color.Transparent;
            this.lblServices.Location = new System.Drawing.Point(30, 34);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(90, 24);
            this.lblServices.TabIndex = 8;
            this.lblServices.Text = "Services";
            // 
            // lblPacket
            // 
            this.lblPacket.AutoSize = true;
            this.lblPacket.BackColor = System.Drawing.Color.Transparent;
            this.lblPacket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacket.ForeColor = System.Drawing.Color.Transparent;
            this.lblPacket.Location = new System.Drawing.Point(30, 111);
            this.lblPacket.Name = "lblPacket";
            this.lblPacket.Size = new System.Drawing.Size(72, 24);
            this.lblPacket.TabIndex = 9;
            this.lblPacket.Text = "Packet";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(440, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(409, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrices
            // 
            this.txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrices.Location = new System.Drawing.Point(607, 64);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(242, 29);
            this.txtPrices.TabIndex = 17;
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.BackColor = System.Drawing.Color.Transparent;
            this.lblPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrices.Location = new System.Drawing.Point(603, 30);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(68, 24);
            this.lblPrices.TabIndex = 16;
            this.lblPrices.Text = "Prices";
            // 
            // lblServicesDate
            // 
            this.lblServicesDate.AutoSize = true;
            this.lblServicesDate.BackColor = System.Drawing.Color.Transparent;
            this.lblServicesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicesDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblServicesDate.Location = new System.Drawing.Point(312, 30);
            this.lblServicesDate.Name = "lblServicesDate";
            this.lblServicesDate.Size = new System.Drawing.Size(138, 24);
            this.lblServicesDate.TabIndex = 14;
            this.lblServicesDate.Text = "Services Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.servicesPacketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // servicesPacketsToolStripMenuItem
            // 
            this.servicesPacketsToolStripMenuItem.Name = "servicesPacketsToolStripMenuItem";
            this.servicesPacketsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.servicesPacketsToolStripMenuItem.Text = "Services & Packets";
            // 
            // cmbCustoemrs
            // 
            this.cmbCustoemrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustoemrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustoemrs.FormattingEnabled = true;
            this.cmbCustoemrs.Location = new System.Drawing.Point(316, 138);
            this.cmbCustoemrs.Name = "cmbCustoemrs";
            this.cmbCustoemrs.Size = new System.Drawing.Size(242, 32);
            this.cmbCustoemrs.TabIndex = 28;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Location = new System.Drawing.Point(312, 111);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(99, 24);
            this.lblCustomer.TabIndex = 29;
            this.lblCustomer.Text = "Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 139);
            this.dataGridView1.TabIndex = 30;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbDate.Location = new System.Drawing.Point(316, 61);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(242, 32);
            this.cmbDate.TabIndex = 31;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblEmployeeName.Location = new System.Drawing.Point(30, 224);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(177, 24);
            this.lblEmployeeName.TabIndex = 32;
            this.lblEmployeeName.Text = "Employee Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(224, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Employee Name ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 24);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Location = new System.Drawing.Point(603, 111);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(106, 24);
            this.lblDateTime.TabIndex = 35;
            this.lblDateTime.Text = "OrderDate";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColemanFitnessClub.Properties.Resources.legacy_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 406);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustoemrs);
            this.Controls.Add(this.txtPrices);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblServicesDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPacket);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.cmbPacket);
            this.Controls.Add(this.cmbservices);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbservices;
        private System.Windows.Forms.ComboBox cmbPacket;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblPacket;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrices;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Label lblServicesDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesPacketsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCustoemrs;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateTime;
    }
}