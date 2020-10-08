namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 P1 = new Class1("Naruto", 30);
            Class1 P2 = new Class1("Naruto", 30);


            Struct1 P3 = new Struct1("Sasuke", 30);
            Struct1 P4 = new Struct1("Sasuke", 30);

            System.Console.WriteLine(Equals(P1,P2));
            System.Console.WriteLine(Equals(P3,P4));
        }
    }
}
