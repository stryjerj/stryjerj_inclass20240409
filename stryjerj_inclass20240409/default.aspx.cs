using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stryjerj_inclass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbFruits.Items.Add("Strawberry");
            }
        }

        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblChosenFruit.Text = lbFruits.SelectedValue;
            // This code runs when the user selects a new item from the lbFruits
            // Copy the currently selected item from the list box into our lbl
        }
        // I need an event when the user, in their browser selects a fruit from the list box
    }
}