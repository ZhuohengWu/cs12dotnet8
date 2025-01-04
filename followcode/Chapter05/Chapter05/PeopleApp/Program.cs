using Packt.Shared;

ConfigureConsole();

// Person bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.

Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call to ToString().
                // WriteLine(bob.ToString()); // Does the same thing.


bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.

WriteLine(format: "{0} was born on {1:D}.", // Long date.
  arg0: bob.Name, arg1: bob.Born);



Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", // Short date.
  arg0: alice.Name, arg1: alice.Born);


// Setting a single enum value works.
bob.FavoriteAncientWonder =
  WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

/*
// Setting multiple enum values throws an exception.
bob.FavoriteAncientWonder = 
  WondersOfTheAncientWorld.StatueOfZeusAtOlympia |
  WondersOfTheAncientWorld.GreatPyramidOfGiza;

// Setting an invalid enum value throws an exception.
bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;
*/

WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);



#region Storing multiple values using collections

// Works with all versions of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

/*
foreach (Person child in bob.Children)
{
  WriteLine($"> {child.Name}");
}
*/

#endregion


#region Making a field static

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
  arg0: gerrierAccount.AccountName,
  arg1: gerrierAccount.Balance * BankAccount.InterestRate);

#endregion