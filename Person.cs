public class Person
{
    private string name;
    private int age;
    private string town;
    private string emailAddress;

    // mehtods for this class
    

    //constructor 0 parametors
    public Person()
    {
        name = "";
        age = 0;
        town = "";
        emailAddress = "";
    }
    public Person(string nameIn, int ageIn, string townIn, string emailAddressIn)
    {
        name = nameIn;
        age = ageIn;
        town = townIn;
        emailAddress = emailAddressIn;
    }
    public void setName(string nameIn)
    {
        name = nameIn;
    }
    public void setAge(int ageIn)
    {
        age = ageIn;
    }
    public void setTown(string townIn)
    {
        town = townIn;
    }
    public void setEmailAddress(string emailAddressIn)
    {
        emailAddress = emailAddressIn;
    }
    // Getter method 
    public string getName()
    {
        return name;
    }
    public int Age()
    {
        return age;
    }
    public string getTown()
    {
        return town;

    }
    public string getEmail()
    {
        return emailAddress;
    }

}
