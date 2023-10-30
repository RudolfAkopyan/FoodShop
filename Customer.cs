public class Customer
    //New class for saving customer data
{
    
    private string firstName;
    private string lastName;
    private string emailAddress;
    private string comment;

    public Customer() // set data for customer input
    {
        firstName = "Rudolf";
        lastName = "Akopyan";
        emailAddress = "";
        comment = "";
       


    }
    public Customer(string firstNameIn, string lastNameIn, string emailAddressIn, string commentIn) // method to pass parameters
    {
        firstName = firstNameIn;
        lastName = lastNameIn;
        emailAddress = emailAddressIn;
        comment = commentIn;
    }
    public void setfirstname(string firstNameIn)
    {
        firstName = firstNameIn;
    }
    public void setlastName(string lastNameIn)
    {
        lastName = lastNameIn;
    }
    public void setemailAddress(string emailAddressIn)
    {
        emailAddress = emailAddressIn;
    }
    public void setcomment(string commentIn)
    {
        comment = commentIn;
    }
    public string getfirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public string getemailAddress()
    {
        return emailAddress;
    }
    public string getComment()
    {
        return comment;
    }

}