using System.Data;
using System.Xml;

class IfStatement
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number: \t");
        int number = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("The Number is: \t " + number);


        if (number > 10 || number < 10) 
        {
            Console.WriteLine("number is greater than 10");
        } 
        else
        {
            Console.WriteLine("number is not greater than 10");
        }

    }
}