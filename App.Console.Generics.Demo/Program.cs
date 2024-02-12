using App.Console.Generics.Demo.Classes;

// Single type parameters
var obString = new DataStore<string>() { Value = "Aijaz Ali" };
Console.WriteLine(obString.Value);


var obInt = new DataStore<int>() { Value = 100 };
Console.WriteLine(obInt.Value);


var obBool = new DataStore<bool>() {  Value = false };
Console.WriteLine(obBool.Value); // and so on...!


var dataStore = new DataStore<string>();

dataStore.AddArr(0, "Java");
dataStore.AddArr(1, "Php");
dataStore.AddArr(2, "Asp");
dataStore.AddArr(3, "Python");

Console.WriteLine(dataStore.GetArr(0));
Console.WriteLine(dataStore.GetArr(1));
Console.WriteLine(dataStore.GetArr(2));
Console.WriteLine(dataStore.GetArr(3));

// Miltiple type parameters
var kvp1 = new KeyValPair<string, int>()
{
     Key = "Aijaz",
     Value = 100
};
Console.WriteLine(kvp1.Key);
Console.WriteLine(kvp1.Value);

var kvp2 = new KeyValPair<string, string>()
{
    Key = "Aijaz",
    Value = "Ali"
};
Console.WriteLine(kvp2.Key);
Console.WriteLine(kvp2.Value);

var kvp3 = new KeyValPair<string, bool>()
{
    Key = "Is aijaz good?",
    Value = true
};
Console.WriteLine(kvp3.Key);
Console.WriteLine(kvp3.Value);

var p1 = new Printer();

p1.PrintName<string>("Lightweight printer");
p1.PrintName(500);

Console.WriteLine(p1.GetName<string>("I am GetName return type Generic method")); // automatically infers
Console.WriteLine(p1.GetName(false));
