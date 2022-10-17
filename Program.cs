// Jacob Dekok
// 10/17/22
// Git Hub Transfer - Mini Challenge #3 Asking questions
// This is a console project that will ask the user
// what their name is and what time they woke up. Then it will output them


Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

Console.WriteLine("What is your name?");
string yourName = Console.ReadLine();
Console.WriteLine("Hello " + yourName + ", just out of curiosity what time did you wake up this morning?");
string wakeUpTime = Console.ReadLine();
Console.WriteLine(yourName + " woke up at " + wakeUpTime + " today.");

Console.WriteLine("Would you like to give me another name and time? 'YES' 'NO'");
playAgain = Console.ReadLine().ToUpper();

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }
}
