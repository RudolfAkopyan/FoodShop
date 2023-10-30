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
    public partial class Page1 : System.Web.UI.Page
    {
        private int Total;
        private List<Food> FruitsList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //   Responce.Rederect
            // next for strings is saving parameters for name of product, size , amount of calories , and picture of product
            Food Fruits1 = new Food("Apple", "Small", 100, "https://post.healthline.com/wp-content/uploads/2020/09/Do_Apples_Affect_Diabetes_and_Blood_Sugar_Levels-732x549-thumbnail-1-732x549.jpg");
            Food Fruits2 = new Food("Orange", "Medium", 300, "https://ichef.bbci.co.uk/images/ic/1200x675/p0cdvvpd.jpg");
            Food Fruits3 = new Food("Banana", "Big", 450, "https://cdnn21.img.ria.ru/images/49873/01/498730163_0:177:2928:1824_1920x0_80_0_0_93fb227fb06f559b14009d1939cdf718.jpg");
            Food Fruits4 = new Food("Peach", "Small", 130, "https://www.bobtailfruit.co.uk/pub/media/mageplaza/blog/post/g/e/gettyimages-614938268.jpeg");
            FruitsList.Add(Fruits1);
            FruitsList.Add(Fruits2);
            FruitsList.Add(Fruits3);
            FruitsList.Add(Fruits4);

            creategrdFruits(); //calling method

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
        public void creategrdFruits() // creating method for data table
        {
            DataTable FoodDT = new DataTable();
            FoodDT.Columns.Add("foodName"); //add foodName button 
            FoodDT.Columns.Add("size"); // add size button 
            FoodDT.Columns.Add("calories"); //add calories buttom
            FoodDT.Columns.Add("picture");  //add picture  
            FoodDT.Columns.Add("btnAddCalories");

            foreach (Food Cereals in FruitsList)
            {
                FoodDT.Rows.Add(
                Cereals.getFoodName(),
                Cereals.getSize(),
                Cereals.getCalories(),
                Cereals.getPicture()
                );
            }
            grdFruits.DataSource = FoodDT;
            grdFruits.DataBind();

            int rowNumber = 0;
            foreach (Food Fruits in FruitsList)
            {
                System.Web.UI.WebControls.Image FruitsPicture = new System.Web.UI.WebControls.Image {
                    ImageUrl = Fruits.getPicture(), 
                    Height = 75, //setting parameters for picture size
                    Width = 75
                };
                grdFruits.Rows[rowNumber].Cells[3].Controls.Add(FruitsPicture);
                rowNumber++;
            }
            int rowNoForBtn = 0;
            foreach (Food Fruits in FruitsList) //setting parameters for add button 
            {
                // 
                Button btnAddCalories = new Button {
                    Text = "Add calories",
                    CommandName = Convert.ToString(Fruits.getCalories())
                };
                btnAddCalories.Command += new CommandEventHandler(btnAddCalories_Click);
                grdFruits.Rows[rowNoForBtn].Cells[4].Controls.Add(btnAddCalories);
                rowNoForBtn++;
            }
        }
        protected void btnAddCalories_Click(object sender, CommandEventArgs e) // method to sum all calories what was added
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

        protected void button1_Click(object sender, EventArgs e) 
        {
            //Response.Redirect("Fruits.aspx");
            Session["Total"] = null;
            lblTotal.Text = "Total kcal: 0"; // clear all calories
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
    }
}