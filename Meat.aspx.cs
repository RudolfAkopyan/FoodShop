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
    public partial class Page3 : System.Web.UI.Page
    {
        private int Total;
        private List<Food> MeatList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {

            //   Responce.Rederect
            // next for strings is saving parameters for name of product, size , amount of calories , and picture of product
            Food meat1 = new Food("Pork", "Small", 300, "https://images.squarespace-cdn.com/content/v1/5ec2868d721a7913afa2741d/1591965536043-5TROEMB8WMT67LNMWM74/the-healthy-butcher-pork-rib-roast-186kg.jpg");
            Food meat2 = new Food("Duck", "Medium", 700, "https://post.healthline.com/wp-content/uploads/2020/08/duck-meat-732x549-thumbnail.jpg");
            Food meat3 = new Food("Lamb", "Big", 1200, "https://d1u3tvp6g3hoxn.cloudfront.net/media/wysiwyg/cookingstudio/recipe/36/36_lamb_00.jpg");
            Food meat4 = new Food("Beef", "Small", 400, "https://cdn.britannica.com/68/143268-050-917048EA/Beef-loin.jpg");
            MeatList.Add(meat1);
            MeatList.Add(meat2);
            MeatList.Add(meat3);
            MeatList.Add(meat4);

            creategrdMeat(); //calling method

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
        public void creategrdMeat() // creating method for data table
        {
            DataTable FoodDT = new DataTable();
            FoodDT.Columns.Add("foodName"); //add foodName button 
            FoodDT.Columns.Add("size"); // add size button 
            FoodDT.Columns.Add("calories"); //add calories buttom
            FoodDT.Columns.Add("picture");  //add picture  
            FoodDT.Columns.Add("btnAddCalories");

            foreach (Food meat in MeatList)
            {
                FoodDT.Rows.Add(
                meat.getFoodName(),
                meat.getSize(),
                meat.getCalories(),
                meat.getPicture()
                );
            }
            grdMeat.DataSource = FoodDT;
            grdMeat.DataBind();

            int rowNumber = 0;
            foreach (Food meat in MeatList)
            {
                System.Web.UI.WebControls.Image meatPicture = new System.Web.UI.WebControls.Image {
                    ImageUrl = meat.getPicture(),
                    Height = 75,
                    Width = 75
                };
                grdMeat.Rows[rowNumber].Cells[3].Controls.Add(meatPicture);
                rowNumber++;
            }
            int rowNoForBtn = 0;
            foreach (Food meat in MeatList)
            {
                // 
                Button btnAddCalories = new Button {
                    Text = "Add calories",
                    CommandName = Convert.ToString(meat.getCalories())
                };
                btnAddCalories.Command += new CommandEventHandler(btnAddCalories_Click);
                grdMeat.Rows[rowNoForBtn].Cells[4].Controls.Add(btnAddCalories);
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