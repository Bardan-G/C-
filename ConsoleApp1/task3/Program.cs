byte mybyte= 10;
short myshort = 20;
int a = 10;
long b = 20;
float c = 10003;
double d = 1000.3;
decimal e = 1000.3M;
char F = 'a';
bool g = false;

// second
int value = 42;
Console.WriteLine(Convert.ToString(value));

//third
string aa = "3.14159";
double bb = Convert.ToDouble(aa);
Console.WriteLine(bb);

// fourth 
Console.WriteLine($"byte:{mybyte}");
Console.WriteLine($"short:{myshort}");
Console.WriteLine($"int:{a}");
Console.WriteLine($"long:{b}");
Console.WriteLine($"float:{c}");
Console.WriteLine($"double:{d}");
Console.WriteLine($"char:{F}");
Console.WriteLine($"bool:{g}");
Console.WriteLine($"value:{value}");
Console.WriteLine($"string:{bb}");

