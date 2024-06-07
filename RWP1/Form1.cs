using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWP1
{
    public partial class Form1 : Form
    {
        IPerson new_persona;
        HashSet<int> indexes = new HashSet<int>();
        public Form1()
        {
            InitializeComponent();
            PersonsInf.DrawMode = DrawMode.OwnerDrawVariable;
            PersonsInf.Refresh();
        }
        public bool Prinyat = false;
        public bool admin = false;


        public List<IPerson> AllPersons = new List<IPerson>();

        private void Creation_Click(object sender, EventArgs e)
        {
            Prinyat = false;
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Persons_Now(AllPersons);
            f2.ShowDialog();
            PersonsInf.Refresh();
            if (Prinyat)
            {
                new_persona = f2.new_person();
                AllPersons.Add(new_persona);
                PersonsInf.Items.Add(new_persona.Name + "    " + new_persona.calcAge(DateTime.Today) + " ");
            }
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (PersonsInf.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить выбранную запись?", "Подтверждение действия", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (AllPersons[PersonsInf.SelectedIndex].Parents != null)
                    {
                        for (int i = 0; i < AllPersons[PersonsInf.SelectedIndex].Parents.Count; ++i)
                        {
                            AllPersons[PersonsInf.SelectedIndex].removeParents(AllPersons[PersonsInf.SelectedIndex].Parents[i]);
                        }
                    }
                    if (AllPersons[PersonsInf.SelectedIndex].Couple != null)
                    {
                        AllPersons[PersonsInf.SelectedIndex].removeCouple(AllPersons[PersonsInf.SelectedIndex].Couple);
                    }
                    if (AllPersons[PersonsInf.SelectedIndex].Children != null)
                    {
                        for (int i = 0; i < AllPersons[PersonsInf.SelectedIndex].Children.Count; ++i)
                        {
                            AllPersons[PersonsInf.SelectedIndex].removeChild(AllPersons[PersonsInf.SelectedIndex].Children[i]);
                        }
                    }
                    AllPersons.RemoveAt(PersonsInf.SelectedIndex);
                    PersonsInf.Items.RemoveAt(PersonsInf.SelectedIndex);
                }
                PersonsInf.Refresh();
            }
            else
            {
                MessageBox.Show("Для удаления необходимо выбрать строку");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (PersonsInf.SelectedIndex != -1)
            {
                Prinyat = false;
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Persons_Now(AllPersons);
                f2.Default_Name_Date_Card(AllPersons[PersonsInf.SelectedIndex], admin);
                f2.ShowDialog();
                PersonsInf.Refresh();
                if (Prinyat)
                {
                    new_persona = f2.new_person();
                    AllPersons[PersonsInf.SelectedIndex] = new_persona;
                    PersonsInf.Items[PersonsInf.SelectedIndex] = (new_persona.Name + "    " + new_persona.calcAge(DateTime.Today) + " ");
                }
                admin = f2.admin;
            }
            else
            {
                MessageBox.Show("Для изменения необходимо выбрать строку");
            }
        }

        private void PersonsInf_DrawItem(object sender, DrawItemEventArgs e)
        {
            if((AllPersons.Count != 0) && (PersonsInf.SelectedIndex != -1))
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                if(indexes.Contains(e.Index))
                    myBrush = Brushes.DarkRed;
                e.Graphics.DrawString(PersonsInf.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }else if ((AllPersons.Count != 0) && (PersonsInf.SelectedIndex == -1))
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                e.Graphics.DrawString(PersonsInf.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        private void PersonsInf_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexes.Clear();
            indexes.Add(PersonsInf.SelectedIndex);
            var cPerson = AllPersons[PersonsInf.SelectedIndex];
            if (cPerson.Parents != null)
            {
                for (int i = 0; i < cPerson.Parents.Count; i++)
                {
                    indexes.Add(AllPersons.IndexOf(cPerson.Parents[i]));
                }
            }
            if (cPerson.Couple != null)
                indexes.Add(AllPersons.IndexOf(cPerson.Couple));
            if (cPerson.Children != null)
            {
                for (int i = 0; i < cPerson.Children.Count; ++i)
                {
                    indexes.Add(AllPersons.IndexOf(cPerson.Children[i]));
                }
            }
            PersonsInf.Refresh();
        }
    }
}
