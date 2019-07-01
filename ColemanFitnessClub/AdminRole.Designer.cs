namespace ColemanFitnessClub
{
    partial class AdminRole
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
            this.btnDlete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDlete
            // 
            this.btnDlete.BackColor = System.Drawing.Color.Red;
            this.btnDlete.Location = new System.Drawing.Point(261, 226);
            this.btnDlete.Name = "btnDlete";
            this.btnDlete.Size = new System.Drawing.Size(152, 40);
            this.btnDlete.TabIndex = 0;
            this.btnDlete.Text = "Delete";
            this.btnDlete.UseVisualStyleBackColor = false;
            this.btnDlete.Click += new System.EventHandler(this.btnDlete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(79, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEdit.Location = new System.Drawing.Point(430, 226);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(152, 40);
            this.lblEdit.TabIndex = 2;
            this.lblEdit.Text = "Edit";
            this.lblEdit.UseVisualStyleBackColor = false;
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(89, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 29);
            this.txtName.TabIndex = 3;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(348, 59);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(222, 32);
            this.cmbRole.TabIndex = 4;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // AdminRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColemanFitnessClub.Properties.Resources.SIT_vs_HIIT_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 319);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDlete);
            this.Name = "AdminRole";
            this.Text = "AdminRole";
            this.Load += new System.EventHandler(this.AdminRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDlete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button lblEdit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}