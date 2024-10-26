using System;

namespace Lab_33
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            string interest = Request.QueryString["interest"];
            lblInterest.Text = $"Calculated Simple Interest: {interest}";
        }
    }
}