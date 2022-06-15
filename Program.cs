int a = 23;
int b = 354;
a = a ^ b;
b = a ^ b;
a = a ^ b;
System.Console.WriteLine($"{a} {b}");