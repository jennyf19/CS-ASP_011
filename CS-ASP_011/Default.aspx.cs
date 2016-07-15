using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       /* protected void okButton_Click(object sender, EventArgs e)
        {
            if (firstTextBox.Text == secondTextBox.Text)
            {
                resultLabel.Text = "Yes! They're equal!";
            }
            else
            {
                resultLabel.Text = "These two values are not equal.";

            }
        }*/

        protected void catcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (catcheckBox.Checked == true)
            {
                catLabel.Text = "Yes! I like cats too!";
            }
            else
            {
                catLabel.Text = "Cats are amazing";
            }


        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "You must be from Chicago.";
            }
            else if (tacosRadioButton.Checked)
            {
                resultLabel.Text = "You must be from California.";
            }
            else if (iceCreamRadioButton.Checked)
            {
                resultLabel.Text =
                    "You must be from Alaska.";
            }
            else if (turkeyRadioButton.Checked)
            {
                resultLabel.Text = "You should be vegan";
            }
            else
            {
                resultLabel.Text = "Please select one of the options";
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void tacosRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void iceCreamRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}