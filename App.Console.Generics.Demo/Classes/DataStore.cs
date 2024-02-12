namespace App.Console.Generics.Demo.Classes
{
    internal class DataStore<T>
    {
        //public T data;
        public T Value { get; set; }    
        private T[] _planguages = new T[5];

        public void AddArr(int index, T item)
        {
            _planguages[index] = item;
        }

        public T GetArr(int index)
        {
            return _planguages[index];
        }
    }
}
