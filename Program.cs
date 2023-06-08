using System;
using System.Linq;
using System.Collections.Generic;// Add this line to import the necessary namespace, required to use 'List<T>' class


class Program //defines a class named Program
{
    static void Main()// It is the starting point for the execution of the program.
    {
       //creates a new instance of the Table class named table. It uses the new keyword to instantiate the object.
        Table table = new Table();
        Table table1 = new Table();
        Table table2 = new Table();
        

        // Create Guest objects
       Guest guest1 = new Guest {
        name= "Marilyn Monroe",
        occupation= "entertainer",
        bio= "(1926 - 1962) American actress, singer, model"
      };

      Guest guest2 =new Guest {
        name= "Abraham Lincoln",
        occupation= "politician",
        bio= "(1809 - 1865) US President during American civil war"
      };

      Guest guest3 =new Guest {
        name= "Martin Luther King",
        occupation= "activist",
        bio= "(1929 - 1968)  American civil rights campaigner"
      };

      Guest guest4 =new Guest {
        name= "Rosa Parks",
        occupation= "activist",
        bio= "(1913 - 2005)  American civil rights activist"
      };

      Guest guest5 =new Guest {
        name= "Peter Sellers",
        occupation= "entertainer",
        bio= "(1925 - 1980) British actor and comedian"
      };

      Guest guest6 =new Guest {
        name= "Alan Turing",
        occupation= "computer scientist",
        bio= "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
      };

      Guest guest7 =new Guest {
        name= "Admiral Grace Hopper",
        occupation= "computer scientist",
        bio= "(1906–1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
      };

      Guest guest8 =new Guest {
        name= "Indira Gandhi",
        occupation= "politician",
        bio= "(1917 - 1984) Prime Minister of India 1966 - 1977",
      };

 // Assign the guests to the table
   
      table.guestTable.Add(guest1);
      table.guestTable.Add(guest2);
      table.guestTable.Add(guest3);
      table.guestTable.Add(guest4);
      table.guestTable.Add(guest5);
      table.guestTable.Add(guest6);
      table.guestTable.Add(guest7);
      table.guestTable.Add(guest8);

// iterate table and for each guest check if guest occupation is in table1 (true) and not in table2 (false)...if so adds guest to table2...otherwise adds guest to table
foreach (Guest guest in table.guestTable)
{
    bool isOccupationDuplicateInTable1 = table1.guestTable.Exists(g => g.occupation == guest.occupation);
    bool isOccupationDuplicateInTable2 = table2.guestTable.Exists(g => g.occupation == guest.occupation);

    if (isOccupationDuplicateInTable1 && !isOccupationDuplicateInTable2)
    {
        table2.guestTable.Add(guest);
    }
    else
    {
        table1.guestTable.Add(guest);
    }
}

//iterate table1 and print out each guest
        Console.WriteLine("Guests in Table 1:");
        table1.guestTable.ForEach(guest=>
        
           {
            Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
           }
        );

        Console.WriteLine();

//iterate table2 and print out each guest
       Console.WriteLine("Guests in Table 2:");
       table2.guestTable.ForEach(guest=>
        
          {
            Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
          }
        );


    }
}





// class Program //defines a class named Program
// {
//     static void Main()// It is the starting point for the execution of the program.
//     {
//         //  declares a variable named guests of type List<Guest>. calls the getGuests() function and assigns its return value (a list of Guest objects) to the guests variable.
//         List<Guest> guests = getGuests();
//        //creates a new instance of the Table class named table. It uses the new keyword to instantiate the object.
//         Table table = new Table();
//         //assign empty arrays of type string[] to the table1 and table2 properties of the table object.
//         Table table1 =  new List<string>();//set to a new array with a length of 0,creating an empty array.
//         Table table2 =  new List<string>();

//     foreach (var guest in guests)
//         {
//             if (table.table1.Any(g => g == guest.occupation))
//             {
//                 table.table2.Add(guest.occupation);
//             }
//             else
//             {
//                 table.table1.Add(guest.occupation);
//             }
//             Console.WriteLine(table.table1);
//         }

//     }

//     // A function to make and return a list of guests
//     static List<Guest> getGuests()
//     {
//         // Make a list of Guest objects
//         List<Guest> guests = new List<Guest> {
//         new Guest {
//         name= "Marilyn Monroe",
//         occupation= "entertainer",
//         bio= "(1926 - 1962) American actress, singer, model"
//       },

//       new Guest {
//         name= "Abraham Lincoln",
//         occupation= "politician",
//         bio= "(1809 - 1865) US President during American civil war"
//       },

//       new Guest {
//         name= "Martin Luther King",
//         occupation= "activist",
//         bio= "(1929 - 1968)  American civil rights campaigner"
//       },

//       new Guest {
//         name= "Rosa Parks",
//         occupation= "activist",
//         bio= "(1913 - 2005)  American civil rights activist"
//       },

//       new Guest {
//         name= "Peter Sellers",
//         occupation= "entertainer",
//         bio= "(1925 - 1980) British actor and comedian"
//       },

//       new Guest {
//         name= "Alan Turing",
//         occupation= "computer scientist",
//         bio= "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
//       },

//       new Guest {
//         name= "Admiral Grace Hopper",
//         occupation= "computer scientist",
//         bio= "(1906–1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
//       },

//       new Guest {
//         name= "Indira Gandhi",
//         occupation= "politician",
//         bio= "(1917 - 1984) Prime Minister of India 1966 - 1977",
//       }
//     };

//         return guests;
//     }
// }

 
   



