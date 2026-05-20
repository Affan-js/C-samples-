class Arith
{
    static void Main (string [] args)
    {
        // alternative if used Console.Write your cursor will be on that line instead of the next 
        Console.WriteLine ("Enter Your Name: \t");
        string name = Console.ReadLine ();
        Console.WriteLine ("Your name is: {0} " , name);


        // getting 2 numbers from an input
         Console.WriteLine ("Enter First Number: \t");
         int num1 = Convert.ToInt16 (Console.ReadLine());


         Console.WriteLine("Enter The Second Number: \t");
         int num2 = Convert.ToInt16(Console.ReadLine());    

        Console.WriteLine ("First Number is:  {0} , Second Number is:  {1} " , num1 , num2 );

        int sum = num1 + num2;
        int diff = num1 - num2;
        int multi = num1 * num2;
        int div = num1 / num2;
        int remainder = num1 % num2;

        Console.WriteLine("--------Results-------");
        Console.WriteLine("The Sum is: {0}\n" , sum);
        Console.WriteLine("The difference is: {0}\n" , diff);
        Console.WriteLine("The multiplied is: {0}\n" , multi);
        Console.WriteLine("The divided answer is: {0}\n" , div);
        Console.WriteLine("The remainder is: {0}\n" , remainder);
    } 
}