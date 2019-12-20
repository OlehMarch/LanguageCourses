namespace DBCourseProject
{
    partial class PrivilegeChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegeChoiceForm));
            this.GB_TypeOfEntrance = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.B_User = new System.Windows.Forms.Button();
            this.GB_AdminDataForEnter = new System.Windows.Forms.GroupBox();
            this.L_Error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.GB_TypeOfEntrance.SuspendLayout();
            this.GB_AdminDataForEnter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_TypeOfEntrance
            // 
            this.GB_TypeOfEntrance.Controls.Add(this.label1);
            this.GB_TypeOfEntrance.Controls.Add(this.button2);
            this.GB_TypeOfEntrance.Controls.Add(this.B_User);
            this.GB_TypeOfEntrance.Location = new System.Drawing.Point(49, 24);
            this.GB_TypeOfEntrance.Name = "GB_TypeOfEntrance";
            this.GB_TypeOfEntrance.Size = new System.Drawing.Size(438, 115);
            this.GB_TypeOfEntrance.TabIndex = 3;
            this.GB_TypeOfEntrance.TabStop = false;
            this.GB_TypeOfEntrance.Text = "Enter as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "or";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_User
            // 
            this.B_User.Location = new System.Drawing.Point(260, 43);
            this.B_User.Name = "B_User";
            this.B_User.Size = new System.Drawing.Size(125, 40);
            this.B_User.TabIndex = 0;
            this.B_User.Text = "User";
            this.B_User.UseVisualStyleBackColor = true;
            this.B_User.Click += new System.EventHandler(this.B_User_Click);
            // 
            // GB_AdminDataForEnter
            // 
            this.GB_AdminDataForEnter.Controls.Add(this.L_Error);
            this.GB_AdminDataForEnter.Controls.Add(this.label3);
            this.GB_AdminDataForEnter.Controls.Add(this.TB_Password);
            this.GB_AdminDataForEnter.Enabled = false;
            this.GB_AdminDataForEnter.Location = new System.Drawing.Point(49, 168);
            this.GB_AdminDataForEnter.Name = "GB_AdminDataForEnter";
            this.GB_AdminDataForEnter.Size = new System.Drawing.Size(438, 108);
            this.GB_AdminDataForEnter.TabIndex = 4;
            this.GB_AdminDataForEnter.TabStop = false;
            this.GB_AdminDataForEnter.Text = "Enter your password (only admin):";
            // 
            // L_Error
            // 
            this.L_Error.AutoSize = true;
            this.L_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Error.ForeColor = System.Drawing.Color.Red;
            this.L_Error.Location = new System.Drawing.Point(206, 38);
            this.L_Error.Name = "L_Error";
            this.L_Error.Size = new System.Drawing.Size(0, 20);
            this.L_Error.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(68, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Password
            // 
            this.TB_Password.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TB_Password.Enabled = false;
            this.TB_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TB_Password.Location = new System.Drawing.Point(203, 61);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(168, 29);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.UseSystemPasswordChar = true;
            this.TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Password_OnKeyDown);
            // 
            // PrivilegeChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 309);
            this.ControlBox = false;
            this.Controls.Add(this.GB_AdminDataForEnter);
            this.Controls.Add(this.GB_TypeOfEntrance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrivilegeChoiceForm";
            this.Text = "Language Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.GB_TypeOfEntrance.ResumeLayout(false);
            this.GB_TypeOfEntrance.PerformLayout();
            this.GB_AdminDataForEnter.ResumeLayout(false);
            this.GB_AdminDataForEnter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_TypeOfEntrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_User;
        private System.Windows.Forms.GroupBox GB_AdminDataForEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_Error;

    }
}