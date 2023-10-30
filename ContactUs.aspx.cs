using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template_Project
{
    public partial class Page5 : System.Web.UI.Page
    {
        private Customer customer; // calling method 

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void lnkFru_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fruits.aspx");
        }

        protected void lnkVeg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vegetables.aspx");
        }

        protected void lnkMeat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meat.aspx");
        }

        protected void lnkCer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cereals.aspx");
        }

        protected void lnkCon_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void button1_Click(object sender, EventArgs e)
        {
           
           
           
            // method to do type and them save user input to the text file
            string firstName = txtFirstname.Text;
            string lastName = txtLastName.Text;
            string emailAddress = txtEmailAddress.Text;
            string comment = txtComment.Text;
            if (firstName == "" || lastName == "" || emailAddress == "" || comment == "") // if statement in case if user didnt fill all data or missed any of them 
            {
                lblConfirm.Text = "Error: Please enter all Details"; // error message 
            }
            else // case if user input was correct and there is no error  
            {
                Customer CustomerCommenting = new Customer();

                CustomerCommenting.setfirstname(firstName);
                CustomerCommenting.setlastName(lastName);
                CustomerCommenting.setemailAddress(emailAddress);
                CustomerCommenting.setcomment(comment);

                writeCustomerToFile(CustomerCommenting);  //calling method
                submissionSuccessful();
            }


        }


        public void writeCustomerToFile(Customer customer) // method that will save customer typed data to the text file
        {
            string location = Server.MapPath("~/");
            string file = Path.Combine(location, "RudolfAkopyan.txt");
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine("Time Submitted: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"));
                sw.WriteLine("First Name: " + customer.getfirstName());
                sw.WriteLine("Last Name: " + customer.getLastName());
                sw.WriteLine("EmailAddress: " + customer.getemailAddress());
                sw.WriteLine("Comment: " + customer.getComment());
                sw.WriteLine("----------------------------------------------------");
            }
        }

        public void submissionSuccessful() // method when  data was submited successfully  
        {
            txtFirstname.Text = "";
            txtLastName.Text = "";
            txtEmailAddress.Text = "";
            txtComment.Text = "";

            lblConfirm.Text = "Details Submitted";
        }
    }
}


