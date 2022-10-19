// Jacob Dekok
// 10/17/22
// Git Hub Transfer - Mini Challenge #3 Asking questions
// This is a console project that will ask the user
// what their name is and what time they woke up. Then it will output them


Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

    bool nameIsNumber = false;
    bool timeIsNumber = false;
    string wakeUpTime = " ";

Console.WriteLine("What is your name?");
string yourName = Console.ReadLine();

    nameIsNumber = Int32.TryParse(yourName, out int numberName);

if(nameIsNumber == true){
    Console.WriteLine("Did your Mom and Dad really name you after a number?");
}

while(timeIsNumber == false)
{
    Console.WriteLine(yourName + ", just out of curiosity what time did you wake up this morning?");
    wakeUpTime = Console.ReadLine();

    timeIsNumber = Int32.TryParse(wakeUpTime, out int numberTime);

    if(timeIsNumber == false){
    Console.WriteLine("That wasn't really a time, I'll ask again. ");
}
}

Console.WriteLine(yourName + " woke up at " + wakeUpTime + " today.");

Console.WriteLine("Would you like to give me another name and time? 'YES' 'NO'");
playAgain = Console.ReadLine().ToUpper();

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }
}
