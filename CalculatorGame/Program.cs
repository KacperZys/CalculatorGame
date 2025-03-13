namespace CalculatorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Make random numbers in division more random so numbers wont be the same most of the time
            var menu = new Menu();
            var date = DateTime.UtcNow;
            string name = Helpers.GetName();
            menu.ShowMenu(name, date);
        }
    }
}
