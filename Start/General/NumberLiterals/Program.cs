// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini

// TODO: Starting in C# 7, you can use _ as a number separator. NO AFECTA AL RESULTADO
int d = 123_456; 
float f = 1_234.5f;
var x = 0xAB_CD_EF;               // hexa
var b = 0b1101_1110_1001_0010;     // binario

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");
