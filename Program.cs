// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки через запятую");
int[] arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
 
int a = arr[0];
int b = arr[1];
int c = arr[2];

Console.WriteLine("Введите координаты второй точки через запятую");
int[] arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
 
int a2 = arr[0];
int b2 = arr[1];
int c2 = arr[2];

Console.WriteLine($"Длина отрезка между введеными точками {Math.Sqrt(Math.Pow(a2-a, 2)+Math.Pow(b2-b, 2)+Math.Pow(c2-c, 2))}");

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов:\n");
for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.WriteLine($"{k}, ");
}
