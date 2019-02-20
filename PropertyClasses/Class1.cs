using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyClasses
{
    public class Class1
    {
        //attributes/ fields
        private string fname;
        private string lname;
        private decimal noofRoom;
        public const decimal roomRent = 500;
        private decimal totalCost;
        private string condimentList;

        //properties
        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }


        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


        public decimal NoofRoom
        {
            get
            {
                return noofRoom;
            }
            set
            {
                noofRoom = value;
            }
        }


        //buy method
        public decimal Buy()
        {

            return totalCost = this.noofRoom * roomRent;
        }

        //clear button
        public string Clear()
        {
            return null ;
        }

        //clear num
        public decimal ClearNum()
        {
            return 0;
        }
       

        public string CondimentsList
        {
            get
            {
                condimentList = string.Empty;//refreshes to empty list
                if (Fname != null)
                    condimentList += fname + "  ";
                if (Lname != null)
                    condimentList += lname + " ";

                return condimentList;
            }
            set
            {
                condimentList = value;
            }
        }



        //constructor
        public Class1()
        {
            Fname = Lname = null; NoofRoom = 0;
        }

        //overloaded constructor
        public Class1(string fn, string ln, decimal nor)
        {
            Fname = fn;
            Lname = ln;
            NoofRoom = nor;

        }


        public override string ToString()
        {
            string output = string.Empty;
            output = "Thank You" + "  ";
            if (CondimentsList != string.Empty)
                output += " " + CondimentsList;
            return output;
        }



    }
}
