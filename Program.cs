namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Quadcopter();
            a.Charge();
            Console.WriteLine(string.Join(" ", a.GetComponents()));
        }
    }
}
