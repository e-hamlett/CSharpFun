namespace Lessons
{
    public partial class Pear
    {
        public Pear(string message, string something, string ripe)
        {
            Console.WriteLine(message + " " + something + " " + ripe);
            Peel();
            Color();
        }
        partial void Peel();

        partial void Color()
        {
            Console.WriteLine("The color of the " + message + " is Red.");
        }
    }
}