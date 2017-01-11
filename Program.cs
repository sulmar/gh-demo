using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var user = new User { FirstName = "Marcin", LastName = "Sulecki" };

        System.Console.WriteLine(user);
    }
}

class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString() => FullName;

}
