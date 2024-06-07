namespace RWP1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonsInf = new System.Windows.Forms.ListBox();
            this.Creation = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.DeleteSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonsInf
            // 
            this.PersonsInf.FormattingEnabled = true;
            this.PersonsInf.ItemHeight = 16;
            this.PersonsInf.Location = new System.Drawing.Point(48, 40);
            this.PersonsInf.Name = "PersonsInf";
            this.PersonsInf.Size = new System.Drawing.Size(395, 356);
            this.PersonsInf.TabIndex = 0;
            this.PersonsInf.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.PersonsInf_DrawItem);
            this.PersonsInf.SelectedIndexChanged += new System.EventHandler(this.PersonsInf_SelectedIndexChanged);
            // 
            // Creation
            // 
            this.Creation.Location = new System.Drawing.Point(532, 40);
            this.Creation.Name = "Creation";
            this.Creation.Size = new System.Drawing.Size(237, 32);
            this.Creation.TabIndex = 1;
            this.Creation.Text = "Создать новую запись";
            this.Creation.UseVisualStyleBackColor = true;
            this.Creation.Click += new System.EventHandler(this.Creation_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(532, 126);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(237, 36);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить выбранную";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(532, 213);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(237, 36);
            this.DeleteSelected.TabIndex = 3;
            this.DeleteSelected.Text = "Удалить выбранную";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Возраст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Creation);
            this.Controls.Add(this.PersonsInf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PersonsInf;
        private System.Windows.Forms.Button Creation;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button DeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

