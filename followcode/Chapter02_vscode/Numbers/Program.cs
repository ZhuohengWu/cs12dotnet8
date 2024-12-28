/*uint naturalNumber = 23;
int integerNumber = -23;
float realNumber = 2.3f;
double anotherRealNumber = 2.3;*/


/* int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Check the three variables have the same value.
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine(
  $"{decimalNotation == hexadecimalNotation}");

// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

// Output the variable values in hexadecimal.
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}"); */


Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range \n{int.MinValue:N0} \n\tto \n{int.MaxValue:N0}.\n");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range \n{double.MinValue:N0} \n\tto \n{double.MaxValue:N0}.\n");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range \n{decimal.MinValue:N0} \n\tto \n{decimal.MaxValue:N0}.\n");
