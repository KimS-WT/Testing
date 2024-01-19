// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// CIDM 3312 Lab 1: Review of Lists and Methods
// Read README.md for instructions. IN VS Code, press Ctrl+Shift+V or Cmd+Shift+V to preview the README.md file

// Task 1: Create a new, empty list of strings here.
List<string> myListOfStrings = new List<string>();

// Task 2: Add 3 strings to your list - their values can be anything.
// Case Sensitive - later compared with userInput
myListOfStrings.Add("Teal");
myListOfStrings.Add("Gold");
myListOfStrings.Add("Silver");

// Task 3: Iterate or loop through your list with a foreach loop printing each element to the console.
Console.WriteLine("The following is a list of colors: ");
foreach (string element in myListOfStrings)
{
    Console.WriteLine(element);
}

// Task 4: Save and run your program with dotnet run.
// Push your changes to github.
// Check github.com and see if your changes are in the repository online

// Task 5: Write code that checks if your list contains a specific string. If it does, remove it from your list.
// Display a message to the console stating that the specific string was removed from the list 
// or it was not removed from the list.
// Test this code with a string that exists in your list and a string that does not exist in your list.
Console.WriteLine("Please enter the color to be removed from the list if it exists.");
string userInput = Console.ReadLine();
if (userInput != null && userInput.Length > 0)
{
    // Make userInput match case sensitvity of elements.
    string unwantedColor = Char.ToUpper(userInput[0]) + userInput.Substring(1).ToLower();

    if (myListOfStrings.Contains(unwantedColor))
    {
        myListOfStrings.Remove(unwantedColor);
        Console.WriteLine($"The {unwantedColor} color has been removed from the list! The list now has the following {myListOfStrings.Count()} colors remaining: ");
    }
    else
    {
        Console.WriteLine($"The {unwantedColor} color is not on the list! The list has the following {myListOfStrings.Count()} colors: ");
    }
}
else
{
    Console.WriteLine($"The input was invalid. The list has the following {myListOfStrings.Count()} colors: ");
}
foreach (string element in myListOfStrings)
{
    Console.WriteLine(element);
}
// Task 6: Clear the list and verify that it is cleared by printing out its Count to the console
Console.WriteLine("The list will now be cleared!");
myListOfStrings.Clear();
Console.WriteLine($"The list has been cleared and now consists of {myListOfStrings.Count()} colors!");

// Task 7: Save and run your program. Answer the questions in README.md. You can modify README.md directly
// from inside VS Code. Put your name at the top of the README.md file


// Task 8: Push your changes to GitHub and verify that they are uploaded


// Congratulations. You just completed your first lab exercise and practiced lists and git. Good work.   