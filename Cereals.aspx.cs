using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template_Project
{
    public partial class Page4 : System.Web.UI.Page
    {
        private int Total;
        private List<Food> CerealsList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //   Responce.Rederect
            // next for strings is saving parameters for name of product, size , amount of calories , and picture of product
            Food Cereals1 = new Food("Rice", "Small", 30, "https://www.simplyrecipes.com/thmb/VxAEr43aVQTyg_087drDx0p52gg=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2020__02__HTC-White-Rice-Lead-3-5073a46b67124ca8b405143cd373da0c.jpg");
            Food Cereals2 = new Food("Corn", "Medium", 50, "https://cdn.britannica.com/36/167236-050-BF90337E/Ears-corn.jpg");
            Food Cereals3 = new Food("Wheat", "Big", 100, "https://cdn.britannica.com/90/94190-050-C0BA6A58/Cereal-crops-wheat-reproduction.jpg");
            Food Cereals4 = new Food("Rye", "Small", 30, "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Ear_of_rye.jpg/1200px-Ear_of_rye.jpg");
            CerealsList.Add(Cereals1);
            CerealsList.Add(Cereals2);
            CerealsList.Add(Cereals3);
            CerealsList.Add(Cereals4);

            creategrdCereals(); //calling method

            if (Session["Total"] == null) // if statement in case if total == 0 
            {
                Total = 0;                
                lblTotal.Text = "Total kcal: 0"; // label total output in this case when total = 0
            }
            else
            {
                Total = Convert.ToInt32(Session["Total"]);  // else statement in case when total > 0 
                lblTotal.Text = "Total kcal: " + Total; // output in this case
            }


        }
        public void creategrdCereals() // creating method for data table
        {
            DataTable FoodDT = new DataTable();
            FoodDT.Columns.Add("foodName"); //add foodName button 
            FoodDT.Columns.Add("size"); // add size button 
            FoodDT.Columns.Add("calories"); //add calories buttom
            FoodDT.Columns.Add("picture");  //add picture  
            FoodDT.Columns.Add("btnAddCalories");

            foreach (Food Cereals  in CerealsList)
            {
                FoodDT.Rows.Add(
                Cereals.getFoodName(),
                Cereals.getSize(),
                Cereals.getCalories(),
                Cereals.getPicture()
                ) ; 
            }
            grdCereals.DataSource = FoodDT;
            grdCereals.DataBind();

            int rowNumber = 0;
            foreach (Food Cereals in CerealsList) // method to set image parametors as height and width
            {
                System.Web.UI.WebControls.Image CerealsPicture = new System.Web.UI.WebControls.Image {
                    ImageUrl = Cereals.getPicture(), 
                    Height = 75,
                    Width = 75
                };
                grdCereals.Rows[rowNumber].Cells[3].Controls.Add(CerealsPicture);
                rowNumber++;
            }
                int rowNoForBtn = 0;
            foreach (Food Cereals in CerealsList)
            {
                // class to add calories buttom, used forcheach loop, will work as much as user will click "add" 
                Button btnAddCalories = new Button {
                    Text = "Add calories",
                    CommandName = Convert.ToString(Cereals.getCalories())
                };
                btnAddCalories.Command += new CommandEventHandler(btnAddCalories_Click);
                grdCereals.Rows[rowNoForBtn].Cells[4].Controls.Add(btnAddCalories);
                rowNoForBtn++;
            }
        }
        protected void btnAddCalories_Click(object sender, CommandEventArgs e)  // method for saving total number of calories and showing output in "total" label 
        {
            int Calories = Convert.ToInt32(e.CommandName);
            if (Session["Total"] == null)
            {
                Total = Calories;
                Session["Total"] = Total;
            }
            else
            {
                Session["Total"] =
                    Convert.ToInt32(Session["Total"]) + Calories;

                Total = Convert.ToInt32(Session["Total"]);

            }
            lblTotal.Text = "Total kcal: " + Total;
        }
        
        protected void linkButton2_Click(object sender, EventArgs e)
        {

        }

        protected void Fruits_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fruits.aspx");
        }

        protected void lnkCer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cereals.aspx");
        }

        protected void lnkFru_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fruits.aspx");
        }

        protected void lnkVeg_Click(object sender, EventArgs e)

        {
            Response.Redirect("Vegetables.aspx");

        }

        protected void lnkCon_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }

        protected void button1_Click(object sender, EventArgs e) //CLEAR
        {
            Session["Total"] = null;
            lblTotal.Text = "Total kcal: 0";
        }
    }
}