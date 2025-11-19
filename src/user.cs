namespace workshop;

abstract class User
{
    private int cpr;
    private string password;
    public string name;
    private int age;
    private string role;
}

class Borrower : User
{
    List<Media> borrowedMedia = new List<Media>{};

    public Borrower(List<Media> borrowed)
    {
        borrowedMedia = borrowed;
    }

    public List<Media> getLoans()
    {
        
    }

    public void loan()
    {
        
    }

    public void returnMedia()
    {
        
    }

    public List<Media> getMedia()
    {
        
    }
}


