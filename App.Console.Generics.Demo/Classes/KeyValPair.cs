namespace App.Console.Generics.Demo.Classes
{
    internal class KeyValPair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
