using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raivis_Rugelis_MD2
{
    public partial class frmZodiacDescription : Form
    {
        //Global variables
        string[] zodiacInfo = { }; 

        public frmZodiacDescription()
        {
            InitializeComponent();
        }
        //This function will be used when form is call - to set info.
        public void SetZodiacInfo(string zodiacDescription)
        {
            //Split info - use | as seperator
            zodiacInfo = zodiacDescription.Split('|');
            Console.WriteLine("Info set result: " + zodiacDescription);
            //Update info in fields
            DisplayZodiacSignInformation();
        }
        //For updating info fields.
        private void DisplayZodiacSignInformation()
        {
            //Specific info in specific table
            tbZodiacSign.Text = zodiacInfo[0];
            tbZodiacElement.Text = zodiacInfo[1];
            tbZodiacMotto.Text = zodiacInfo[2];
            tbZodiacDay.Text = zodiacInfo[3];
            tbZodiacColor.Text = zodiacInfo[4];
            tbZodiacPlanet.Text = zodiacInfo[5];
            tbZodiacLuckyNumber.Text = zodiacInfo[6]; 
        }
        //Event for close button
        private void btnCloseDescription_Click(object sender, EventArgs e)
        {
            //Close THIS form.
            this.Close();
        }
    }
}
