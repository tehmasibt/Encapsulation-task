namespace encap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Age = 20;
            user.Username = "Tehmasib";
            user.Password = "Taghiyev1829";
            Console.WriteLine(user.Username);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Password);
        }
    }
}
