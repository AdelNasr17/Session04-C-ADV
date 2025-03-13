namespace Session04
{
    internal class Session04
    {
        static void Main(string[] args)
        {
       

            #region Part 01 : Hashtable
            //Hashtable PhoneBook = new Hashtable( new StringEqualityComperer())
            //{
            //    { "Mona", 111 },
            //    //  PhoneBook.Add(null, 222);//INVALID
            //    { "Adel", 222 },
            //    { "Amr", 333 }
            //};


            #region Add New Element

            ////  PhoneBook.Add("Mona", 500); // Unsafe

            //if (!PhoneBook.ContainsKey("Mona"))
            //    PhoneBook.Add("Mona", 500);


            #endregion

            #region Indexer
            //// usong indexer to get value
            //Console.WriteLine(PhoneBook["Amr"]);


            //// usong indexer to set value
            //PhoneBook["Adel"] = 1000;



            //for (int i = 0;i < PhoneBook.Count;i++)
            //    Console.WriteLine(PhoneBook[i]);

            //PhoneBook["Mona"] = 1000;

            //PhoneBook["Maryam"] = 1000;


            //foreach (var item in PhoneBook) 
            //    Console.WriteLine(item);
            #endregion

            #region Iteration on Hashtable 
            //foreach (var item in PhoneBook.Values)
            //    Console.WriteLine(item); 


            //foreach (DictionaryEntry item in PhoneBook)
            //    Console.WriteLine($"Person Name : {item.Key} , Number : {item.Value} ");
            #endregion

            #endregion

            #region Part 02 : Genric Dictionary 

            #region Example 01 ;
            //Dictionary<string, int> PhoneNote = new Dictionary<string, int>()
            //{
            //    { "Mona ", 111},
            //    { "Adel ", 222},
            //     { "Salma ", 333}
            //};

            //KeyValuePair<string, int>[] array =
            //{

            //    new ("mona" , 123),
            //    new ("Ahmad", 789)
            //};
            //PhoneNote = new Dictionary<string, int>(array , new StringEqualityComperer() );
            //PhoneNote.Add("ADEL", 234); 

            #region interation on Dictionary

            //foreach (string phone in PhoneNote.Keys)
            //    Console.WriteLine(phone);

            //foreach (KeyValuePair<string, int> phone in PhoneNote)
            //    Console.WriteLine(phone); 
            #endregion

            #region Indexer

            //// Using Indexer As Getter
            //Console.WriteLine(PhoneNote["Mona"]); //111

            //// Using Indexer As Setter

            //PhoneNote["Sama"] = 1000;

            //// if found => Reset 
            //// if not foung  => Add 

            //  Console.WriteLine("Sama"); //Unsafe

            //bool Result=  PhoneNote.TryGetValue("Sama" , out int number);
            //  Console.WriteLine(Result); // False 
            //  Console.WriteLine(number); // 0 

            //  if (PhoneNote.ContainsKey("Sama"))
            //      Console.WriteLine(PhoneNote["Sama"]); // -- safe 


            #endregion
            #endregion

            #region Example 02 
            //Session04.Employee employee01 = new Session04.Employee(1, "Adel", 10000);
            //Session04.Employee employee02 = new Session04.Employee(2, "Mona", 5000);
            //Session04.Employee employee03 = new Session04.Employee(3, "Salama", 8000);

            //Dictionary<Session04.Employee, string> employee = new Dictionary<Session04.Employee, string>()
            //{
            //    [employee01] = "1st",
            //    [employee02] = "2nd",
            //    [employee03] = "3rd"
            //};


            //    //   [Id = 1
            //    // Name = Adel
            //    // Salary = 10000, 1st]
            //    //[Id = 2
            //    // Name = Mona
            //    // Salary = 5000, 2nd]
            //    //[Id = 3
            //    // Name = Salama
            //    // Salary = 8000, 3rd]
            //    //[Id = 2

            //Session04.Employee employee04 = new Session04.Employee(2, "Mona", 5000);

            //employee.Add(employee04 , "4th");

            //    // [Id = 1
            //    // Name = Adel
            //    // Salary = 10000, 1st]
            //    //[Id = 2
            //    // Name = Mona
            //    // Salary = 5000, 2nd]
            //    //[Id = 3
            //    // Name = Salama
            //    // Salary = 8000, 3rd]
            //    //[Id = 2
            //    // Name = Mona
            //    // Salary = 5000, 4th]


            //foreach (var item in employee)
            //    Console.WriteLine(item);


            #endregion




            #endregion

            #region Part 03 : Sorted Dictionary

            #region Example 01 :
            //SortedDictionary<string, int> phoneNote = new(comparer: new StringComperer())
            //{
            //    ["Salma"]=111,
            //    ["Omr"] = 222,
            //    ["Ali"] =333,
            //    ["Adel"] =444,

            //};

            //foreach (var phone in phoneNote)
            //    Console.WriteLine(phone);

            #endregion


            #region Example 02 :
            //Session04.Employee employee02 = new Session04.Employee(2, "Mona", 5000);
            //Session04.Employee employee01 = new Session04.Employee(1, "Adel", 10000);
            //Session04.Employee employee03 = new Session04.Employee(3, "Salama", 8000);


            //SortedDictionary<Session04.Employee, string> employee = new SortedDictionary<Session04.Employee, string>( new EmployeeNameComperer())
            //{
            //    [employee01] = "1st",
            //    [employee02] = "2nd",
            //    [employee03] = "3rd"
            //};


            //foreach (var item in employee)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Part 04 : Sorted List :

            // SortedList<string, int> phoneNote = new(comparer: new StringComperer())
            // {
            //     ["Salma"] = 111,
            //     ["Omr"] = 222,
            //     ["Ali"] = 333,
            //     ["Adel"] = 444,

            // };

            //int number = phoneNote.GetValueAtIndex(1);
            // string name = phoneNote.GetKeyAtIndex(1);
            // Console.WriteLine($" Number : {number} , Name : {name}");

            // foreach (var item in phoneNote)
            // {
            //     Console.WriteLine(item);
            // }


            #endregion

            #region Part 05 : 



            #endregion

            
        }
    }
}
