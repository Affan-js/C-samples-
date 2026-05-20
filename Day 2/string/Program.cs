class StringExample
{
    static void Main (string[] args)
    {
        string s1 = "Hello Earth" ;
        Console.WriteLine("s1: "+ s1.ToUpper());
        //Their other once like ToLower 

        string s2 = "HELLO EARTH";
        Console.WriteLine("s1: "+ s2.ToLower());

        //integer to string convert 
        int age =23;
        string s3 = age.ToString();
        Console.WriteLine("s3 is : "+ s3);

        // string Composition 
        //formatting string 
        string text2 = string.Format("Value of age : {0}  , Value of S1: {1} , Value of S2: {2} " , age ,s1 ,s2 );
        Console.WriteLine(text2);
        //another formatting method 
        string text3 = $"age: {age}, Value of S2: {s2}";
        Console.WriteLine(text3);

        // right inside the writeline 
        Console.WriteLine("Value of age : {0}  , Value of S1: {1} , Value of S2: {2} " , age ,s1 ,s2);
        Console.WriteLine($"age: {age}, Value of S2: {s2}");

        // spacing and new line !remove the " , "!
        Console.WriteLine("Value of age : {0} \n Value of S1: {1} \n Value of S2: {2} \n " , age ,s1 ,s2);
        Console.WriteLine("Value of age : {0} \t Value of S1: {1} \t Value of S2: {2} \t " , age ,s1 ,s2);
    } 
}