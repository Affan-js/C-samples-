class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 10;
        Console.WriteLine($"a is {a} \nb is {b}");

        bool res = a == b; // a is equal to b
        Console.WriteLine("a == b: \t" + res);

        bool res2 = a != b; // 10 is not equal to 20
        Console.WriteLine($"a != b: \t {res2}");
        // <  lessthan
        // > greaterthan
        bool res3 = a < b; // a is lessthan b 
        Console.WriteLine("a < b: \t {0}", res3);

         bool res4 = a <= b; // a is lessthan b or a is equal to b
        Console.WriteLine("a <= b: \t {0}", res4);

        bool res5 = a > b; // a is greaterthan b
        Console.WriteLine("a > b: \t {0}", res5);

         bool res6 = a >= b; // a is greaterthan b or equal to b
        Console.WriteLine("a >= b: \t {0}", res6);

        // ==, !=, <, <=, >, >= conditional operators

        // logical operators

        /*
        
        and &&
        or ||

        */
        bool rez1 = a < 10 && a > 20;
        Console.WriteLine("a lessthan 10 AND is a greater then 20\t {0}", rez1);

        bool rez2 = a < 10 || a > 20;
        Console.WriteLine("a lessthan 10 OR is a greater then 20\t {0}", rez2);



    }
}