namespace Equality
{
    struct Struct1
    {
        public Struct1(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }
        string Name { get; set; }
        int Age { get; set; }
    }
}
