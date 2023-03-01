// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 100;
Console.WriteLine(number1);//20

int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };
numbers1 = numbers2;
numbers2[0] = 1000;
Console.WriteLine(numbers1[0]);//1000

 