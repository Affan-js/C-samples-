class SwitchStatement
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: \t");
        int number = Convert.ToInt32(Console.ReadLine());

        //switch case
        switch (number)
        {
            case 1: 
            Console.WriteLine("One");
            break;

            case 2:
            Console.WriteLine("Two");
            break;

            case 3: 
            Console.WriteLine("Three");
            break;

            default: 
            Console.WriteLine("The number is " + number);
            break;
        }
    }
}