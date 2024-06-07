using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWP1
{
    public partial class Form2 : Form
    {
        IPerson persona;
        public List<IPerson> AllPersons = new List<IPerson>();
        public Form2()
        {
            InitializeComponent();
            Admin_GIF.Visible = false;
            label_have_users1.Visible = false;
            label_have_users2.Visible = false;
            DateOfBithday.MaxDate = DateTime.Today;
            DateOfBithday.Value = DateOfBithday.MaxDate;

        }
        public IPerson new_person()
        {
            int cn;
            int.TryParse(CardNumber.Text, out cn);
            string nm = NameOfPerson.Text;
            DateTime bd = DateOfBithday.Value;
            if (persona == null)
                persona = new Person(cn, nm, bd);
            else
            {
                persona.Name = nm;
                persona.Bithday = bd;
                persona.CardNumber = cn;
            }
            if (persona.Parents != null)
            {
                for (int i = 0; i < persona.Parents.Count; ++i)
                {
                    persona.removeParents(persona.Parents[i]);
                }
            }
            if (persona.Couple != null)
            {
                persona.removeCouple(persona.Couple);
            }
            if (persona.Children != null)
            {
                for (int i = 0; i < persona.Children.Count; ++i)
                {
                    persona.removeChild(persona.Children[i]);
                }
            }
            if (Parent1.SelectedIndex != -1)
                persona.addParents(AllPersons[Parent1.SelectedIndex]);
            if (Parent2.SelectedIndex != -1)
                persona.addParents(AllPersons[Parent2.SelectedIndex]);
            if (Couple.SelectedIndex != -1)
                persona.addCouple(AllPersons[Couple.SelectedIndex]);
            foreach (int i in Children.CheckedIndices)
            {
                persona.addChild(AllPersons[i]);
            }
            return persona;
        }
        public bool admin;
        private string OldNumber;

        protected void Access_Click(object sender, EventArgs e)
        {
            bool coincidence = false;
            foreach (int i in Children.CheckedIndices)
            {
                if (i != -1 && ((Parent1.SelectedIndex == i) || (Parent2.SelectedIndex == i) || (Couple.SelectedIndex == i) || (AllPersons.IndexOf(persona) == i)))
                    coincidence = true;
            }
            if (Parent1.SelectedIndex != -1 && (Parent1.SelectedIndex == Parent2.SelectedIndex || Parent1.SelectedIndex == Couple.SelectedIndex || Parent1.SelectedIndex == AllPersons.IndexOf(persona)))
                coincidence = true;
            if (Parent2.SelectedIndex != -1 && (Parent2.SelectedIndex == Couple.SelectedIndex || Parent2.SelectedIndex == AllPersons.IndexOf(persona)))
                coincidence = true;
            if (Couple.SelectedIndex != -1 && Couple.SelectedIndex == AllPersons.IndexOf(persona))
                coincidence = true;
            if ((CardNumber.Text != "") && (NameOfPerson.Text != "") && (CardNumber.Text.Length == 5) && (!coincidence) && (CardNumber.Text[0] != '0'))
            {
                Form1 f1 = (Form1)this.Owner;
                f1.Prinyat = true;
                this.Close();
            }
            else
            {
                if (NameOfPerson.Text == "")
                {
                    MessageBox.Show("Введите имя держателя карты", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (CardNumber.Text == "")
                {
                    MessageBox.Show("Введите пятизначный номер карты", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                if (CardNumber.Text.Length < 5)
                {
                    MessageBox.Show("Номер карты должен быть ровно пятизначным", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                if (CardNumber.Text[0] == '0')
                {
                    MessageBox.Show("Номер карты не может начинаться с '0'", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (coincidence)
                    MessageBox.Show("Одиному и тому же человеку присвоены разные роли в семье", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar <= 47) || (e.KeyChar >= 58)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        public void Default_Name_Date_Card(IPerson persona, bool ad)
        {
            this.persona = persona;
            if (ad)
            {
                admin = true;
                this.BackColor = Color.AliceBlue;
                this.ChangeEnables();
                this.GifVisibility();
            }
            NameOfPerson.Text = persona.Name;
            DateOfBithday.Value = persona.Bithday;
            CardNumber.Text = persona.CardNumber.ToString();
            OldNumber = persona.CardNumber.ToString();
            if (persona.Parents != null)
            {
                for (int i = 0; i < persona.Parents.Count; i++)
                {
                    if (i == 0)
                    {
                        Parent1.SelectedIndex = AllPersons.IndexOf(persona.Parents[i]);
                    }
                    else
                    {
                        Parent2.SelectedIndex = AllPersons.IndexOf(persona.Parents[i]);
                    }
                }
            }
            if (persona.Couple != null)
                Couple.SelectedIndex = AllPersons.IndexOf(persona.Couple);
            if (persona.Children != null)
            {
                for (int i = 0; i < persona.Children.Count; ++i)
                {
                    Children.SetItemChecked(AllPersons.IndexOf(persona.Children[i]), true);
                }
            }
            ChangeEnables();
            if (AllPersons.Count <= 1)
            {
                label_have_users1.Visible = false;
                label_have_users2.Visible = false;
                Parent1.Enabled = false;
                Parent2.Enabled = false;
                Children.Enabled = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.L | Keys.Shift):
                    if ((!admin) && (!DateOfBithday.Enabled) && (!CardNumber.Enabled))
                    {
                        Form3 f3 = new Form3();
                        f3.Owner = this;
                        f3.Show();
                    }
                    else if (admin)
                    {
                        MessageBox.Show("Вы уже администратор");
                    }
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public void ChangeEnables()
        {
            if ((!DateOfBithday.Enabled) && (!CardNumber.Enabled) && (!ClearAllFields.Enabled))
            {
                DateOfBithday.Enabled = true;
                CardNumber.Enabled = true;
                ClearAllFields.Enabled = true;
                Parent1.Enabled = true;
                Parent2.Enabled = true;
                Children.Enabled = true;
            }
            else
            {
                DateOfBithday.Enabled = false;
                CardNumber.Enabled = false;
                ClearAllFields.Enabled = false;
                Parent1.Enabled = false;
                Parent2.Enabled = false;
                Children.Enabled = false;
            }
        }

        public void Persons_Now(List<IPerson> all_persons)
        {
            AllPersons = all_persons;
            if (AllPersons.Count < 1)
            {
                label_have_users1.Visible = true;
                label_have_users2.Visible = true;
                Parent1.Enabled = false;
                Parent2.Enabled = false;
                Couple.Enabled = false;
                Children.Enabled = false;
            }
            else
            {
                Parent1.Enabled = true;
                Parent2.Enabled = true;
                Couple.Enabled = true;
                Children.Enabled = true;
                for (int i = 0; i < AllPersons.Count; i++)
                {
                    Parent1.Items.Add(AllPersons[i].CardNumber + "   " + AllPersons[i].Name);
                    Parent2.Items.Add(AllPersons[i].CardNumber + "   " + AllPersons[i].Name);
                    Couple.Items.Add(AllPersons[i].CardNumber + "   " + AllPersons[i].Name);
                    Children.Items.Add(AllPersons[i].CardNumber + "   " + AllPersons[i].Name);
                }
            }
        }

        public void GifVisibility()
        {
            Admin_GIF.Visible = true;
        }

        private void ClearAllFields_Click(object sender, EventArgs e)
        {
            NameOfPerson.Text = "";
            DateOfBithday.Value = DateTime.Today.Date;
            CardNumber.Text = "";
            Parent1.SelectedIndex = -1;
            Parent2.SelectedIndex = -1;
            Couple.SelectedIndex = -1;
            Children.SelectedIndex = -1;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((CardNumber.Text != OldNumber) && (admin))
            {
                Access.Enabled = false;
                if((e.X >= Access.Location.X - 50) && (e.X <= Access.Location.X + Access.Width + 50) && (e.Y >= Access.Location.Y - 50) && (e.Y <= Access.Location.Y + Access.Height + 50))
                {
                    if((Access.Location.X >= 0) && (Access.Location.X <= this.Width - 17) && (Access.Location.Y >= 0) && (Access.Location.Y <= this.Height - Access.Height - 40))
                    {
                        if ((e.X < Access.Location.X + Access.Width/2) && (e.Y < Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X + 50, e.Y + 50);
                        }
                        if ((e.X < Access.Location.X + Access.Width / 2) && (e.Y > Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X + 50, e.Y - 50 - Access.Height);
                        }
                        if ((e.X > Access.Location.X + Access.Width / 2) && (e.Y < Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X - 50 - Access.Width, e.Y  + 50);
                        }
                        if ((e.X > Access.Location.X + Access.Width / 2) && (e.Y > Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X - 50 - Access.Width, e.Y - 50 - Access.Height);
                        }
                        if ((e.X == Access.Location.X + Access.Width / 2) && (e.Y <= Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X, e.Y + 50);
                        }
                        if ((e.X == Access.Location.X + Access.Width / 2) && (e.Y > Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X, e.Y - 50 - Access.Height);
                        }
                        if ((e.X < Access.Location.X + Access.Width / 2) && (e.Y == Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X + 50, e.Y);
                        }
                        if ((e.X > Access.Location.X + Access.Width / 2) && (e.Y == Access.Location.Y + Access.Height / 2))
                        {
                            Access.Location = new Point(e.X - 50 - Access.Width, e.Y);
                        }
                    }
                    if (Access.Location.X < 0)
                        Access.Location = new Point(0, Access.Location.Y);
                    if (Access.Location.X > this.Width - 17 - Access.Width)
                        Access.Location = new Point(this.Width - 17 - Access.Width, Access.Location.Y);
                    if (Access.Location.Y < 0)
                        Access.Location = new Point(Access.Location.X, 0);
                    if (Access.Location.Y > this.Height - 40  - Access.Height)
                        Access.Location = new Point(Access.Location.X, this.Height - 40 - Access.Height);

                    if ((Access.Location.X == 0) && (Access.Location.Y == 0))
                        Access.Location = new Point(this.Width - 17 - Access.Width, this.Height - 40 - Access.Height);
                    else if ((Access.Location.X == 0) && (Access.Location.Y == this.Height - 40 - Access.Height))
                        Access.Location = new Point(this.Width - 17 - Access.Width, 0);
                    else if ((Access.Location.X == this.Width - 17 - Access.Width) && (Access.Location.Y == 0))
                        Access.Location = new Point(0, this.Height - 40 - Access.Height);
                    else if ((Access.Location.X == this.Width - 17 - Access.Width) && (Access.Location.Y == this.Height - 40 - Access.Height))
                        Access.Location = new Point(0, 0);

                }
            }
        }
    }
}
