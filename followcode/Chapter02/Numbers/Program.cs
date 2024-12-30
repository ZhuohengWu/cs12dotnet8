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




string rowSeparator = new string('-', count: 121);
WriteLine(rowSeparator);
WriteLine($"{"Type",-8} {"Byte(s) of memory",-4} {"Min",27} {"Max",40} {"Pwr 2 Min",12} {"Pwr 2 Max",12}");
WriteLine(rowSeparator);


PrintRange($"sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
PrintRange("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
PrintRange("short", sizeof(short), short.MinValue, short.MaxValue);
PrintRange("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
PrintRange("int", sizeof(int), int.MinValue, int.MaxValue);
PrintRange("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
PrintRange("long", sizeof(long), long.MinValue, long.MaxValue);
PrintRange("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
unsafe
{
    PrintRange("Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
    PrintRange("UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
    PrintRange("Half", sizeof(Half), Half.MinValue, Half.MaxValue);
}
PrintRange("float", sizeof(float), float.MinValue, float.MaxValue);
PrintRange("double", sizeof(double), double.MinValue, double.MaxValue);
PrintRange("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
WriteLine(rowSeparator);


decimal testDecimal = int.MaxValue;
testDecimal = 1e11m;
WriteLine(decimal.GetBits(testDecimal).Length); // four int32 = 96 mantissa
WriteLine("decimal value = {0}", testDecimal);
foreach (var bit in decimal.GetBits(testDecimal))
{
    Write(Convert.ToString(bit, 2).PadLeft(32, '0') + " "); // Convert to 32-bit binary and pad with leading zeros
}
WriteLine();


static void PrintRange<T>(string typeName, int size, T min, T max)
{
    int bits = size * 8;

    // usigned types: 0 to 2^n - 1;
    // signed types: -2^(n - 1) to 2^(n - 1) - 1 

    // floating point types: approx powers of 2 (assume half of the bits used for exponent (bits / 2), which is wrong but gives rough idea of the magnitude)
    //  Type    Bits    sign    Exponent    Mantissa
    //  Half    16      1       5           10
    //  float   32      1       8           23
    //  double  64      1       11          52
    //  decimal 128     1       5           96

    string powerOf2Min = typeof(T).IsFloatingPointType()
            ? "~2^-" + (bits / 2)  // approximate limits for floating point types
            : "-2^" + (typeof(T).IsUnsignedType() ? "0" : $"{bits - 1}");

    string powerOf2Max = typeof(T).IsFloatingPointType()
            ? "~2^" + (bits / 2)
            : "2^" + (typeof(T).IsUnsignedType() ? $"{bits} - 1" : $"{bits - 1} - 1");

    Console.WriteLine($"{typeName,-8} {size,-4} {min,40} {max,40} {powerOf2Min,12} {powerOf2Max,12}");
}

static class TypeExtensions
{
    public static bool IsFloatingPointType(this Type type) =>
        type == typeof(float) || type == typeof(double) || type == typeof(decimal) || type == typeof(Half);

    public static bool IsUnsignedType(this Type type) =>
        type == typeof(byte) || type == typeof(ushort) || type == typeof(uint) || type == typeof(ulong) || type == typeof(UInt128);
}