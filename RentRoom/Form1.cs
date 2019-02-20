using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using PropertyClasses;

namespace RentRoom
{
    public partial class Form1 : Form
    {
        private const decimal ROOMRENT = 500;
        Class1 class1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            Buy();



            //decimal total = nudNoRoom.Value * ROOMRENT;
            //txtRoomRent.Text = nudNoRoom.Value.ToString();
            //txtTotal.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            //lblThankYou.Text = "Thank You" + "  " + txtFname.Text + "  " + txtLname.Text;
            //btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("All fields are empty");
            }

            //txtFname.Clear();
            //txtLname.Clear();
            //txtTotal.Clear();
            //txtRoomRent.Clear();
            //lblThankYou.Text = "";
            //nudNoRoom.Value = 0;
            //txtFname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            if (keyData == Keys.Enter)
            {

                Buy();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }




        public void Buy()
        {
            class1 = new Class1(txtFname.Text.ToString(),
                                                    txtLname.Text.ToString(),
                                                    nudNoRoom.Value
                                                     );

            txtRoomRent.Text = class1.NoofRoom.ToString();
            txtTotal.Text = class1.Buy().ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            lblThankYou.Text = class1.ToString();
            btnClear.Focus();
        }


        private void Clear()
        {
            class1 = new Class1();
            txtFname.Text = class1.Clear();
            txtLname.Text = class1.Clear();
            txtTotal.Text = class1.ClearNum().ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            txtRoomRent.Text = class1.ClearNum().ToString();
            lblThankYou.Text = class1.Clear();
            nudNoRoom.Value = class1.ClearNum();
            txtFname.Focus();
        }
    }
}
