using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RWP1
{
    internal class Person: IPerson
    {
        private int CN;
        private string Nm;
        private DateTime Bd;
        private IPerson Cp = null;
        private List<IPerson> Prns = null;
        private List<IPerson> Ch = null;
        public int CardNumber {
            get { return CN; }
            set { CN = value; }
        }
        public string Name {
            get { return Nm; }
            set { Nm = value; }
        }
        public DateTime Bithday {
            get { return Bd; }
            set { Bd = value; }
        }
        public IPerson Couple
        {
            get { return Cp; }
        }

        public List<IPerson> Parents { 
            get { return Prns; }
        }

        public List<IPerson> Children
        {
            get { return Ch; }
        }
        public int calcAge(DateTime date) {
            if (Bithday.Year != date.Year)
            {
                if (Bithday.Month < date.Month)
                {
                    return (date.Year - Bithday.Year);
                }
                if (Bithday.Month == date.Month)
                {
                    if (Bithday.Day < date.Day)
                        return date.Year - Bithday.Year;
                    else
                        return date.Year - Bithday.Year - 1;
                }
                if (Bithday.Month > date.Month)
                {
                    return date.Year - Bithday.Year - 1;
                }
            }
            return 0;
        }
        public Person(int cn, string nm, DateTime bd)
        {
            this.CN = cn;
            this.Nm = nm;
            this.Bd = bd;
        }
        public void addChild(IPerson child)
        {
            if(Ch == null)
            {
                Ch = new List<IPerson>();
            }
            Ch.Add(child);
            if (child.Parents == null || !child.Parents.Contains(this))
                child.addParents(this);
        }
        public void addCouple(IPerson couple)
        {
            Cp = couple;
            if (couple.Couple == null)
                couple.addCouple(this);
        }
        public void addParents(IPerson parent)
        {
            if(Prns == null)
            {
                Prns = new List<IPerson>();
            }
            if (Prns.Count < 2)
            {
                Prns.Add(parent);
                if (parent.Children == null || !parent.Children.Contains(this))
                    parent.addChild(this);
            }
        }
        public void removeChild(IPerson child)
        {
            Ch.Remove(child);
            if (child.Parents.Count != 0 && child.Parents.Contains(this))
                child.removeParents(this);
        }
        public void removeCouple(IPerson couple)
        {
            Cp = null;
            if(couple.Couple != null)
            {
                couple.removeCouple(this);
            }
        }
        public void removeParents(IPerson parent)
        {
            Prns.Remove(parent);
            if (parent.Children.Count != 0 && parent.Children.Contains(this))
                parent.removeChild(this);
        }
    }
}
