// Trieda Book je v samostatnom súbore Book.cs
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public string Describe()
    {
        return Title + " (" + Author + "), " + Pages + " stran";
    }
}
