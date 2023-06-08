
public class Table // defines a class named Table,

//create a public property for holding a list of guests
{
public List<Guest> guestTable { get; set; }

  public Table()//constructor
    {
        guestTable = new List<Guest>();
    }
}