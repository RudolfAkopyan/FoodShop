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
    public partial class Page2 : System.Web.UI.Page
    {
        private int Total;
        private List<Food> VegetablesList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Food Vegetables1 = new Food("Carrot", "Small", 250, "https://www.liveeatlearn.com/wp-content/uploads/2018/04/carrot-on-white-vert.jpg");
            Food Vegetables2 = new Food("Cucumber", "Medium", 480, "https://www.finedininglovers.com/sites/g/files/xknfdk626/files/2022-06/Type%20of%20cucumber.jpg");
            Food Vegetables3 = new Food("Potato", "Big", 700, "https://www.kew.org/sites/default/files/2022-07/Picture_of_many_potatoes.jpg");
            Food Vegetables4 = new Food("Cabbage", "Small", 550, "https://www.freshpoint.com/wp-content/uploads/2020/02/Freshpoint-green-cabbage.jpg");
            VegetablesList.Add(Vegetables1);
            VegetablesList.Add(Vegetables2);
            VegetablesList.Add(Vegetables3);
            VegetablesList.Add(Vegetables4);

            creategrdVegetables(); //calling method

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
        public void creategrdVegetables() // creating method for data table
        {
            DataTable FoodDT = new DataTable();
            FoodDT.Columns.Add("foodName"); //add foodName button 
            FoodDT.Columns.Add("size"); // add size button 
            FoodDT.Columns.Add("calories"); //add calories buttom
            FoodDT.Columns.Add("picture");  //add picture  
            FoodDT.Columns.Add("btnAddCalories");

            foreach (Food Vegetables in VegetablesList)
            {
                FoodDT.Rows.Add(
                Vegetables.getFoodName(),
                Vegetables.getSize(),
                Vegetables.getCalories(),
                Vegetables.getPicture()
                );
            }
            grgVegetables.DataSource = FoodDT;
            grgVegetables.DataBind();

            int rowNumber = 0;
            foreach (Food Vegetables in VegetablesList)
            {
                System.Web.UI.WebControls.Image VegetablesPicture = new System.Web.UI.WebControls.Image {
                    ImageUrl = Vegetables.getPicture(),
                    Height = 75,
                    Width = 75
                };
                grgVegetables.Rows[rowNumber].Cells[3].Controls.Add(VegetablesPicture);
                rowNumber++;
            }
            int rowNoForBtn = 0;
            foreach (Food Vegetables in VegetablesList)
            {
                // 
                Button btnAddCalories = new Button {
                    Text = "Add calories",
                    CommandName = Convert.ToString(Vegetables.getCalories())
                };
                btnAddCalories.Command += new CommandEventHandler(btnAddCalories_Click);
                grgVegetables.Rows[rowNoForBtn].Cells[4].Controls.Add(btnAddCalories);
                rowNoForBtn++;
            }
        }
        protected void btnAddCalories_Click(object sender, CommandEventArgs e)
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["Total"] = null;
            lblTotal.Text = "Total kcal: 0";
        }
    }
}