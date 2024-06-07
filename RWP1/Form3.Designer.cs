namespace RWP1
{
    partial class Form3
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
            this.RoleChoose = new System.Windows.Forms.ComboBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.UserChoose = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RoleChoose
            // 
            this.RoleChoose.FormattingEnabled = true;
            this.RoleChoose.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.RoleChoose.Location = new System.Drawing.Point(309, 118);
            this.RoleChoose.Name = "RoleChoose";
            this.RoleChoose.Size = new System.Drawing.Size(151, 24);
            this.RoleChoose.TabIndex = 0;
            this.RoleChoose.SelectedIndexChanged += new System.EventHandler(this.RoleChoose_SelectedIndexChanged);
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(118, 349);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 1;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(557, 349);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // UserChoose
            // 
            this.UserChoose.AutoSize = true;
            this.UserChoose.Location = new System.Drawing.Point(363, 145);
            this.UserChoose.Name = "UserChoose";
            this.UserChoose.Size = new System.Drawing.Size(46, 32);
            this.UserChoose.TabIndex = 4;
            this.UserChoose.Text = "Логин\r\n\r\n";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(353, 239);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Пароль";
            // 
            // Pass
            // 
            this.Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pass.Enabled = false;
            this.Pass.Location = new System.Drawing.Point(210, 214);
            this.Pass.MaxLength = 10;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(335, 22);
            this.Pass.TabIndex = 6;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserChoose);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.RoleChoose);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoleChoose;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label UserChoose;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Pass;
    }
}