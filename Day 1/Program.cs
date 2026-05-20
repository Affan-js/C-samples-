class FirstProgram
{
    static void Main(string[] args)
    {
        int studentMark; // declartion of a varibale
        studentMark = 67; // init of a varibale

        int studentAge = 19;

        string studentName = "Ahmed"; // string is collection of char/ array
        char studentInitial = 'K';
        float studentScore = 20.22f;
        double studentTotal = 269.833838;
        bool passed = true;

        string fullName = studentName + " " + studentInitial;

        Console.WriteLine("Hello. Welcome to C#" );
        Console.WriteLine("Student name is: " + fullName);
        Console.WriteLine("Student Age is: " + studentAge);
        Console.WriteLine("Student Mark is: " + studentMark);
        Console.WriteLine("Student Score: " + studentScore);
        Console.WriteLine("Student Total mark: " + studentTotal);
        Console.WriteLine("Student passed ?: " + passed);

        passed = false;
        Console.WriteLine("Student passed ?: " + passed);
    }
}