using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWP1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            RoleChoose.SelectedIndex = 0;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)this.Owner;
            string Password, YourPassword;
            using (StreamReader sr = new StreamReader("C:\\Users\\zahar\\source\\repos\\RWP1\\RWP1\\Hash.txt"))
            {
                Password = sr.ReadLine();
                YourPassword = RoleChoose.Text + Pass.Text;
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(YourPassword));
                YourPassword = BitConverter.ToString(checkSum);
            }
            if (YourPassword == Password)
            {
                f2.admin = true;
                f2.BackColor = Color.AliceBlue;
                f2.ChangeEnables();
                f2.GifVisibility();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
            
        }

        private void RoleChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoleChoose.SelectedIndex == 0)
            {
                Pass.Enabled = false;
            }
            if (RoleChoose.SelectedIndex == 1)
            {
                Pass.Enabled = true;
            }

        }
    }
}
