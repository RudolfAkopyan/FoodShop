public class VideoGame
{
    private string title;
    private string genre;
    private int price;
    private string picture;
    
    //counstructor 0 parametors
    public VideoGame()
    {
        title = "";
        genre = "";
        price = 0;
        picture = "";
    }
    //constructor 4 parametors
    public VideoGame(string titleIn, string genreIn, int priceIn, string pictureIn)
    {
            title = titleIn;
            genre = genreIn;
            price = priceIn;
            picture = pictureIn;
    }

    public void setTtle(string titleIn)
    {
        title = titleIn;
    }
    public void setGenre(string genreIn)
    {
        genre = genreIn;
    }
    public void setPicture(string pictureIn)
    {
        picture = pictureIn;
    }
    public string getTitle()
    {
        return title;
    }
    public string getGenre()
    {
        return genre;
    }
    public int getPrice()
    {
        return price;
    }
    public string getPicture()
    {
        return picture;
    }
}