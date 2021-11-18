﻿
namespace ServerTestCode.View.UserControls
{
    partial class ManagerAdminAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNewPassAgain = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChangPassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblManagerAccount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.panelChangePassword);
            this.panel2.Controls.Add(this.btnChangPassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(226, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 422);
            this.panel2.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(12, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(318, 28);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE INFORMATION";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.panel4);
            this.panelChangePassword.Controls.Add(this.panel3);
            this.panelChangePassword.Controls.Add(this.panel1);
            this.panelChangePassword.Controls.Add(this.label9);
            this.panelChangePassword.Controls.Add(this.label8);
            this.panelChangePassword.Controls.Add(this.label7);
            this.panelChangePassword.Location = new System.Drawing.Point(12, 245);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(326, 151);
            this.panelChangePassword.TabIndex = 22;
            this.panelChangePassword.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtNewPassAgain);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(2, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 19);
            this.panel4.TabIndex = 19;
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtNewPassAgain.Location = new System.Drawing.Point(28, 0);
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.Size = new System.Drawing.Size(287, 20);
            this.txtNewPassAgain.TabIndex = 20;
            this.txtNewPassAgain.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ServerTestCode.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(4, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtNewPass);
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 19);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ServerTestCode.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtNewPass.Location = new System.Drawing.Point(27, 0);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(289, 20);
            this.txtNewPass.TabIndex = 19;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtCurrentPass);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 21);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::ServerTestCode.Properties.Resources.unlock__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCurrentPass.Location = new System.Drawing.Point(27, 0);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(289, 20);
            this.txtCurrentPass.TabIndex = 18;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(-3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Re-type New Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(-3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "New Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(-3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Current  Password";
            // 
            // btnChangPassword
            // 
            this.btnChangPassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnChangPassword.Location = new System.Drawing.Point(12, 155);
            this.btnChangPassword.Name = "btnChangPassword";
            this.btnChangPassword.Size = new System.Drawing.Size(112, 23);
            this.btnChangPassword.TabIndex = 21;
            this.btnChangPassword.Text = "Change Password";
            this.btnChangPassword.UseVisualStyleBackColor = true;
            this.btnChangPassword.Click += new System.EventHandler(this.btnChangPassword_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Login Information ";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(12, 119);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(319, 21);
            this.txtUserName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(12, 66);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(319, 21);
            this.txtFullName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Full Name";
            // 
            // lblManagerAccount
            // 
            this.lblManagerAccount.AutoSize = true;
            this.lblManagerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblManagerAccount.Location = new System.Drawing.Point(43, 34);
            this.lblManagerAccount.Name = "lblManagerAccount";
            this.lblManagerAccount.Size = new System.Drawing.Size(241, 24);
            this.lblManagerAccount.TabIndex = 17;
            this.lblManagerAccount.Text = "Manager Admin Account";
            // 
            // ManagerAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblManagerAccount);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ManagerAdminAccount";
            this.Size = new System.Drawing.Size(861, 599);
            this.Load += new System.EventHandler(this.ManagerAdminAccount_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblManagerAccount;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPassAgain;
    }
}
