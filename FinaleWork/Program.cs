﻿// Написать программу, которая из сформированного массива строк содержащих 
// символы и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.

Console.Clear();
char[] elements = new char[10];
string alfabet = "abcdefjhijklmnopqrstuwxyz";
for (int i = 0; i < elements.Length; i++)
{
    int number = new Random().Next(1, 33);
    string number2;
    if (i % 2 == 0)
    {
        number2 = Convert.ToString(alfabet[number]);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
    else
    {
        number = number % 10;
        number2 = Convert.ToString(number);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < elements.Length; i++)
{
    bool mark = elements[i] >= '0' && elements[i] <= '9';
    if (mark == false)
    {
        count++;
    }
}
System.Console.WriteLine();

string[] String = new string[count];
int j = 0;
for (int i = 0; i < elements.Length; i++)
{

    bool mark = elements[i] >= '0' && elements[i] <= '9';
    if (mark == false)
    {

        String[j] = Convert.ToString(elements[i]);
        Console.Write(String[j] + ",");
        j++;
    }
}