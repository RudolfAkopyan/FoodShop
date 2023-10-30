public class Food
    //New class for saving food information
{
    private string foodName;
    private string size;
    private int calories;
    private string picture;

    public Food() // set data for food 
    {
        foodName = "";
        size = "";
        calories = 0;
        picture = "";
    }
    public Food(string foodNameIn, string sizeIn, int caloriesIn, string pictureIn) // method tp pass parametrs
    {
        foodName = foodNameIn;
        size = sizeIn;
        calories = caloriesIn;
        picture = pictureIn;
    }
    public void setFoodName(string foodNameIn)
    {
        foodName = foodNameIn;
    } 
    public void setSize(string sizeIn)
    {
        size = sizeIn;
    }
    public void setCalories(int caloriesIn)
    {
        calories = caloriesIn;
    }
    public void setPicture(string pictureIn)
    {
        picture = pictureIn;
    }
    public string getFoodName()
    {
        return foodName;
    }
    public string getSize()
    {
        return size;
    }
    public int getCalories()
    {
        return calories;
    }
    public string getPicture()
    {
        return picture;
    }
}
