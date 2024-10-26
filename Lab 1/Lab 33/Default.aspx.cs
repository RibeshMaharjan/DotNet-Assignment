using System;
using System.Web.UI;

namespace Lab_33
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);

            // Calculate simple interest
            double simpleInterest = (principal * rate * time) / 100;

            // Redirect to Result page with query string
            Response.Redirect($"result.aspx?interest={simpleInterest}");
        }
    }
}