using System;
using System.Diagnostics;
internal class Exercises_01
{
    static void Main()
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
        Ex10();
        Console.ReadKey();
    }
    //1. to Add / Sum Two Numbers
    static void Ex01()
    {
        int a = 3, b = 4;
        int c = a + b;
        Console.WriteLine($"{a} + {b} = {c}");
    }
    //2. to Swap Values of Two Variables
    static void Ex02()
    {
        int a = 3, b = 4;
        Console.WriteLine($"Truoc khi hoan doi gia tri: a = {a}, b = {b}");
        int tem = a;
        a = b;
        b = tem;
        Console.WriteLine($"Sau khi hoan doi gia tri: a = {a}, b = {b}");
    }
    //3. to Multiply two Floating Point Numbers
    static void Ex03()
    {
        float a = 5.2f, b = 2.6f;
        float c = a * b;
        Console.WriteLine($"{a} * {b} = {c}");
    }
    //4.  To Convert Feet to Meter
    static void Ex04()
    {
        float feet = 5.0f;
        // 1 foot = 0.3048 meters
        float meter = feet * 0.3048f;
        Console.WriteLine($"{feet} feet = {meter} meters");
    }
    //5. To Convert Celsius to Fahrenheit and vice versa
    static void Ex05()
    {
        float celsius = 37.0f;
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} Celsius = {fahrenheit} Fahrenheit");
        fahrenheit = 55.0f;
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} Fahrenheit = {celsius} Celsius");
    }
    //6. to find the Size of data types
    static void Ex06()
    {
        Console.WriteLine($"Kich thuoc cua so nguyen: {sizeof(int)} bytes");
        Console.WriteLine($"Kich thuoc cua so thuc: {sizeof(float)} bytes");
        Console.WriteLine($"Kich thuoc cua double: {sizeof(double)} bytes");
        Console.WriteLine($"Kich thuoc cua mot ky tu: {sizeof(char)} bytes");
        Console.WriteLine($"Kich thuoc cua gia tri dung/sai: {sizeof(bool)} bytes");
    }
    //7. to Print ASCII Value
    static void Ex07()
    {
        Console.Write("Nhap mot ky tu: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int ascii = (int)ch;
        Console.WriteLine($"Gia tri ASCII cua'{ch}' la {ascii}");
    }
    //8. to Calculate Area of Circle
    static void Ex08()
    {
        float r = 7.5f;
        float dt = (float)(Math.PI * r * r);
        Console.WriteLine($"Dien tich hinh tron co ban kinh {r} la {dt}");
    }
    //9.  to Calculate Area of Square 
    static void Ex09()
    {   
        float canh = 2.5f;
        float dt = canh * canh;
        Console.WriteLine($"Dien tich hinh vuong co canh {canh} la {dt}");
    }
    //10. to convert days to years, weeks and days
    static void Ex10()
    {
        int days = 537;
        int years = days / 365;
        int weeks = (days % 365) / 7;
        int remainingDays = (days % 365) % 7;
        Console.WriteLine($"{days} ngay xap xi {years} nam, {weeks} tuan, và {remainingDays} ngay.");
    }
}

