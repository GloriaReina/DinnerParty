// Classes are how we define objects in C#. They help us ensure that our objects always have
//  the correct properties and methods.
public class Guest//defines a class named Guest, which represents a guest and their 3 properties.
{
    public string name { get; set; }// get and set keywords indicate that these properties can be read from(returns the current value) and written to(allows you to modify the value of a property. )
    public string occupation { get; set; }
     public string bio { get; set; }
  
}