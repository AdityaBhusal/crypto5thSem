using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the text to encrypt: ");
        string? userInput = Console.ReadLine();
        Console.WriteLine("Enter the Shift Value: ");
        int shiftValue = Convert.ToInt32(Console.ReadLine());

        if (userInput == null)
        {
            Console.WriteLine("Please enter a valid input");
            return;
        }

        foreach (char a in userInput)
        {
            int temp = ((int)a + shiftValue - 97) % 25 + 97;
            //97 is the ASCII value of 'a'
            //26 is the number of alphabets
            // we are subtracting 97 to get the value of the alphabet in the range of 0-25
            // then we are adding 97 to get the value back in the ASCII range
            // we are using % 26 to wrap around the alphabets
            //if we use 25 instead of 26, we will get the value in the range of 0-25
            Console.Write((char)temp);
        }
    }
}
