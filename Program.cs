//  Valyuta konvertri

using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

System.Console.WriteLine("qiymatni kiriting: ");
double qiymat= Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("valyuta qiymatini kiriting: ");
double valyuta= Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Qiymat= {qiymat} kurs= {valyuta}");
System.Console.WriteLine($"{qiymat*valyuta} so\'m");
