﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Консоль. Write("Введите число: ");
int a = int. Синтаксический анализ(Консоль. ЧитатьЛинию());
Консоль. Write("Введите число: ");
int b = int. Синтаксический анализ(Консоль. ЧитатьЛинию());

if(a > b)
{
    Консоль. WriteLine(a);
}
еще
{
    Консоль. WriteLine(b);
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Консоль. Write("Введите первое число: ");
int a = int. Синтаксический анализ(Консоль. ЧитатьЛинию());
Консоль. Write("Введите второе число: ");
int b = int. Синтаксический анализ(Консоль. ЧитатьЛинию());
Консоль. Write("Введите третее число: ");
int c = int. Синтаксический анализ(Консоль. ЧитатьЛинию());

int max = a;

если (b > макс.)
{
    макс = b;
}
если (c > макс.)
{
    макс = c;
}
Консоль. WriteLine(макс.);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Консоль. Write("Введите число: ");

int a = int. Синтаксический анализ(Консоль. ЧитатьЛинию());

если (a % 2 == 0)
{
   Консоль. WriteLine("Да");
}
еще
{
   Консоль. WriteLine("Нет");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Консоль. Write("Введите число: ");
int N = int. Синтаксический анализ(Консоль. ЧитатьЛинию());
    
int num = 1;

while (число <= N)
{
    если (число % 2 == 0)
    Консоль. Write($"{num} ");
    число++;
}
