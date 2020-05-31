using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Modname
    {
        private string tfname;
        private string tlname;
        private string dob;
        private string allergen;
        private string descript;

        public Modname(string firstname,string lastname, string age)
        {
            Tfname = firstname;
            Tlname = lastname;
            Dob = age;
        }
        public Modname(string Allergy, string Allergydescrip)
        {
            Allergen = Allergy;
            Descript = Allergydescrip;
        }
        

        public string Tfname
        {
            get
            {
                return tfname;
            }
            set
            {
                tfname = value;
            }
        }
        public string Tlname
        {
            get
            {
                return tlname;
            }
            set
            {
                tlname = value;
            }
        }
        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string Allergen
        {
            get
            {
                return allergen;
            }
            set
            {
                allergen = value;
            }
        }
        public string Descript
        {
            get
            {
                return descript;
            }
            set
            {
                descript = value;
            }
        }

    }
}
