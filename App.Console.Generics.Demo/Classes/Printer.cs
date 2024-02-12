namespace App.Console.Generics.Demo.Classes
{
    internal class Printer
    {
        public void PrintName<T>(T name)
        {
            System.Console.WriteLine(name);
        }

        public T GetName<T>(T name)
        {
            return name;
        }
    }
}
