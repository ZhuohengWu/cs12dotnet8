// See https://aka.ms/new-console-template for more information
//#error version

using System.Reflection;

Console.WriteLine("Hello, World!");

WriteLine($"Computer named {Env.MachineName} says \"No.\"");


System.Data.DataSet ds = new();
HttpClient client = new();


Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly == null) return;

foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach(TypeInfo typeInfo in a.DefinedTypes)
    {
        methodCount += typeInfo.GetMethods().Length;
    }

    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine($"Here's a grinning Emoji for you: {grinningEmoji}");

string xml = """
             <person age="59">
                <first_name>Mark</first_name>
             </person>
             """;
WriteLine(xml);
xml = """
             <person age="60">
                <first_name>Bob</first_name>
             </person>
""";
WriteLine(xml);

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
    {
        "first_name": "{{person.FirstName}}",
        "age": {{person.Age}},
        "calculation": "{{{3 + 2}}}";
    }
    """;
WriteLine(json);