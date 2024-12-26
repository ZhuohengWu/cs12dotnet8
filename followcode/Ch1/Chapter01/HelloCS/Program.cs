// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, c#!");

string name = typeof(Program).Namespace ?? "None!";
Console.WriteLine($"Namespace: {name}");

int z;

//throw new Exception();