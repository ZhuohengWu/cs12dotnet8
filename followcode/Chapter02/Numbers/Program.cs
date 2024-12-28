/*int decimalNotation = 2_000_000;
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
Console.WriteLine($"{hexadecimalNotation:X}");

*/


/*Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range \n{int.MinValue:N0} \n\tto \n{int.MaxValue:N0}.\n");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range \n{double.MinValue:N0} \n\tto \n{double.MaxValue:N0}.\n");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range \n{decimal.MinValue:N0} \n\tto \n{decimal.MaxValue:N0}.\n");
*/


/*Console.WriteLine("Using doubles");
double d1 = 0.1;
double d2 = 0.2;
string isEqual = (d1 + d2 == 0.3) ? "equal" : "not equal";
Console.WriteLine($"{d1} + {d2} {isEqual} 0.3");

Console.WriteLine("Using decimal");
decimal e1 = 0.1M;
decimal e2 = 0.2M;
string isEqual2 = (e1 + e2 == 0.3M) ? "equal" : "not equal";
Console.WriteLine($"{e1} + {e2} {isEqual2} 0.3");

Console.WriteLine("Using float");
float f1 = 0.1f;
float f2 = 0.2f;
string isEqual3 = (f1 + f2 == 0.3f) ? "equal" : "not equal";
Console.WriteLine($"{f1} + {f2} {isEqual3} 0.3");*/




string rowSeparator = new string('-', count: 104);
WriteLine(rowSeparator);
WriteLine($"Type    {"Byte(s) of memory",-4} {"Min",32} {"Max",45}");
WriteLine(rowSeparator);
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,45} {sbyte.MaxValue,45}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,45} {byte.MaxValue,45}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,45} {short.MaxValue,45}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,45} {ushort.MaxValue,45}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,45} {int.MaxValue,45}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,45} {uint.MaxValue,45}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,45} {long.MaxValue,45}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,45} {ulong.MaxValue,45}");
unsafe
{
    WriteLine($"Int128  {sizeof(Int128),-4} {Int128.MinValue,45} {Int128.MaxValue,45}");
    WriteLine($"UInt128 {sizeof(UInt128),-4} {UInt128.MinValue,45} {UInt128.MaxValue,45}");
    WriteLine($"Half    {sizeof(Half),-4} {Half.MinValue,45} {Half.MaxValue,45}");
}
WriteLine($"float   {sizeof(float),-4} {float.MinValue,45} {float.MaxValue,45}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,45} {double.MaxValue,45}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,45} {decimal.MaxValue,45}");
WriteLine(rowSeparator);

