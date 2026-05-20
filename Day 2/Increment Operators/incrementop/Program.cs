class Incre
{
    static void Main (string[] args )
    {
        //post increment
        int i = 10;
        int b;
        b = i++; 
        //b = 10
        // i = 11
        Console.WriteLine("i: \t"+i);
        Console.WriteLine("b: \t"+b);

        //pre - increment 
        int x = 10;
        int j;
        j = ++x; // x = x + 1 
        //x = x + 1 =11
        // j = 11
        Console.WriteLine("x: \t"+x);
        Console.WriteLine("j: \t"+j);
        
    }
}