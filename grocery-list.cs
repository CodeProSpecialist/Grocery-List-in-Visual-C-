//create a new c# program that asks for grocery list items to save in an array with a menu input prompt//
//load input text of the grocery list from a text file //


// create a new text file to save the grocery list items within:
string textfilefolder = AppDomain.CurrentDomain.BaseDirectory;
string completefilepathoftextfile = Path.Combine(textfilefolder, "GroceryList.txt");

bool fileExist = File.Exists(completefilepathoftextfile);
if (fileExist)
{
    Console.WriteLine("I found your saved Grocery list at: \n" + completefilepathoftextfile);
}
else
{
    using (File.Create(completefilepathoftextfile)) ;
    Console.WriteLine("You can view your Grocery list at: \n" + completefilepathoftextfile);
}

Console.WriteLine("\nHi, Let's Make a Grocery List. It helps your shopping be a perfect experience. \n");


//read grocery list from the saved text file at C:\Users\Public\GroceryList.txt 
string[] groceryList = System.IO.File.ReadAllLines(@completefilepathoftextfile);

Console.WriteLine("\nHere is the current grocery list: \n");
//list the grocery list items

for (int i = 0; i < groceryList.Length; i++)
{
    Console.WriteLine(groceryList[i], i + 1);
}


//below code adds an item to the grocery list
//input prompt to add an item to the grocery list or press TAB and Enter to skip


Console.WriteLine("\nPlease enter a grocery list item to add an item to the list \nor press TAB and Enter to skip: \n");
//prompt for input 
string ListInput = Console.ReadLine();

//add the input to the array
Array.Resize(ref groceryList, groceryList.Length + 1);
groceryList[groceryList.Length - 1] = ListInput;
//print the array
Console.WriteLine("\n \n \n \n \n Grocery List: ");
for (int i = 0; i < groceryList.Length; i++)
{
    //save the grocery list to a text file
    System.IO.File.WriteAllLines(@completefilepathoftextfile, groceryList);


    Console.WriteLine(groceryList[i]);
}

Console.WriteLine("\nFor your convenience, You have a Grocery list text file at: \n" + completefilepathoftextfile);

//below code adds an option to delete the grocery list 
Console.WriteLine("\n \n \n \n \n (Optional) Would you like to delete the grocery list? (y or n)\n");

//save the answer to a variable
string DeleteQuestion = Console.ReadLine();

//create a new if statement for a yes or no conditon: yes to delete the grocery list 
if (DeleteQuestion == "y")
{
    //  Empty String Variable = "";



    System.IO.File.Delete(@completefilepathoftextfile);
}

Console.WriteLine("Have a Wonderful Day. Enjoy the Shopping Bye.");


