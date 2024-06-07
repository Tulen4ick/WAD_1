namespace RWP1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NameOfPerson = new System.Windows.Forms.TextBox();
            this.DateOfBithday = new System.Windows.Forms.DateTimePicker();
            this.Access = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Admin_GIF = new System.Windows.Forms.PictureBox();
            this.Parent1 = new System.Windows.Forms.ComboBox();
            this.Couple = new System.Windows.Forms.ComboBox();
            this.Parent2 = new System.Windows.Forms.ComboBox();
            this.Children = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_have_users1 = new System.Windows.Forms.Label();
            this.ClearAllFields = new System.Windows.Forms.Button();
            this.label_have_users2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_GIF)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfPerson
            // 
            this.NameOfPerson.Location = new System.Drawing.Point(43, 58);
            this.NameOfPerson.Multiline = true;
            this.NameOfPerson.Name = "NameOfPerson";
            this.NameOfPerson.Size = new System.Drawing.Size(148, 64);
            this.NameOfPerson.TabIndex = 0;
            // 
            // DateOfBithday
            // 
            this.DateOfBithday.Location = new System.Drawing.Point(6, 224);
            this.DateOfBithday.MaxDate = new System.DateTime(2100, 7, 22, 0, 0, 0, 0);
            this.DateOfBithday.Name = "DateOfBithday";
            this.DateOfBithday.Size = new System.Drawing.Size(200, 22);
            this.DateOfBithday.TabIndex = 1;
            this.DateOfBithday.Value = new System.DateTime(2023, 10, 7, 0, 0, 0, 0);
            // 
            // Access
            // 
            this.Access.Location = new System.Drawing.Point(707, 92);
            this.Access.Name = "Access";
            this.Access.Size = new System.Drawing.Size(90, 30);
            this.Access.TabIndex = 2;
            this.Access.Text = "Принять";
            this.Access.UseVisualStyleBackColor = true;
            this.Access.Click += new System.EventHandler(this.Access_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(707, 200);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 31);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отменить";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(31, 362);
            this.CardNumber.MaxLength = 5;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ShortcutsEnabled = false;
            this.CardNumber.Size = new System.Drawing.Size(148, 22);
            this.CardNumber.TabIndex = 4;
            this.CardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер карты";
            // 
            // Admin_GIF
            // 
            this.Admin_GIF.Image = ((System.Drawing.Image)(resources.GetObject("Admin_GIF.Image")));
            this.Admin_GIF.Location = new System.Drawing.Point(377, 37);
            this.Admin_GIF.Name = "Admin_GIF";
            this.Admin_GIF.Size = new System.Drawing.Size(150, 85);
            this.Admin_GIF.TabIndex = 8;
            this.Admin_GIF.TabStop = false;
            this.Admin_GIF.Visible = false;
            // 
            // Parent1
            // 
            this.Parent1.FormattingEnabled = true;
            this.Parent1.Location = new System.Drawing.Point(222, 173);
            this.Parent1.Name = "Parent1";
            this.Parent1.Size = new System.Drawing.Size(216, 24);
            this.Parent1.TabIndex = 9;
            // 
            // Couple
            // 
            this.Couple.FormattingEnabled = true;
            this.Couple.Location = new System.Drawing.Point(349, 263);
            this.Couple.Name = "Couple";
            this.Couple.Size = new System.Drawing.Size(215, 24);
            this.Couple.TabIndex = 10;
            // 
            // Parent2
            // 
            this.Parent2.FormattingEnabled = true;
            this.Parent2.Location = new System.Drawing.Point(461, 172);
            this.Parent2.Name = "Parent2";
            this.Parent2.Size = new System.Drawing.Size(215, 24);
            this.Parent2.TabIndex = 11;
            // 
            // Children
            // 
            this.Children.FormattingEnabled = true;
            this.Children.Location = new System.Drawing.Point(349, 343);
            this.Children.Name = "Children";
            this.Children.Size = new System.Drawing.Size(215, 89);
            this.Children.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Родители";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Супруг(а)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дети";
            // 
            // label_have_users1
            // 
            this.label_have_users1.AutoSize = true;
            this.label_have_users1.Location = new System.Drawing.Point(334, 228);
            this.label_have_users1.Name = "label_have_users1";
            this.label_have_users1.Size = new System.Drawing.Size(252, 16);
            this.label_have_users1.TabIndex = 17;
            this.label_have_users1.Text = "В базе недостаточно пользователей";
            this.label_have_users1.Visible = false;
            // 
            // ClearAllFields
            // 
            this.ClearAllFields.Location = new System.Drawing.Point(707, 311);
            this.ClearAllFields.Name = "ClearAllFields";
            this.ClearAllFields.Size = new System.Drawing.Size(90, 50);
            this.ClearAllFields.TabIndex = 18;
            this.ClearAllFields.Text = "Очистить все поля";
            this.ClearAllFields.UseVisualStyleBackColor = true;
            this.ClearAllFields.Click += new System.EventHandler(this.ClearAllFields_Click);
            // 
            // label_have_users2
            // 
            this.label_have_users2.AutoSize = true;
            this.label_have_users2.Location = new System.Drawing.Point(346, 244);
            this.label_have_users2.Name = "label_have_users2";
            this.label_have_users2.Size = new System.Drawing.Size(225, 16);
            this.label_have_users2.TabIndex = 19;
            this.label_have_users2.Text = "для построения семейных связей";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.Access);
            this.Controls.Add(this.label_have_users2);
            this.Controls.Add(this.ClearAllFields);
            this.Controls.Add(this.label_have_users1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Children);
            this.Controls.Add(this.Parent2);
            this.Controls.Add(this.Couple);
            this.Controls.Add(this.Parent1);
            this.Controls.Add(this.Admin_GIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DateOfBithday);
            this.Controls.Add(this.NameOfPerson);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_GIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfPerson;
        private System.Windows.Forms.DateTimePicker DateOfBithday;
        private System.Windows.Forms.Button Access;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Admin_GIF;
        private System.Windows.Forms.ComboBox Parent1;
        private System.Windows.Forms.ComboBox Couple;
        private System.Windows.Forms.ComboBox Parent2;
        private System.Windows.Forms.CheckedListBox Children;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_have_users1;
        private System.Windows.Forms.Button ClearAllFields;
        private System.Windows.Forms.Label label_have_users2;
    }
}