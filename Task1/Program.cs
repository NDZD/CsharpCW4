// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int NumberOfDigits(int a){
    
int count = 1;
while(a > 9 || a < -9){
    a = a / 10;
    count++;
    }
return count;
}


System.Console.WriteLine(NumberOfDigits(a));