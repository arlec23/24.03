using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           /*Console.WriteLine("Задание 2");
           int a = 10, b = 13;
           if (a==b)
           {
                a = 0;
                b = 0;
           }else
           {
                if (a > b){
                    b = a;
                }else
                {
                 if (a < b){
                    a = b;
                 }
                }
            } // люблю все усложнять :(
            Console.WriteLine ($"{a}, {b}");*/
            
            /* Console.WriteLine("Задание 3");
        double operand1, operand2;
        string sign;
        Console.WriteLine("Введи первое число");
        operand1 = double.Parse(Console.ReadLine());
        Console.WriteLine("А теперь второе");
        operand2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Выбери действие: '+', '-', '/', '*'.");
        sign = Console.ReadLine();
        
        switch (sign)
        {
         case "+":
         Console.WriteLine(operand1 + operand2);
         break;
         case "-":
         Console.WriteLine(operand1 - operand2);
         break;
         case "*":
         Console.WriteLine(operand1 * operand2);
         break;
         case "/":
         if (operand2 == 0)
                  {
                        Console.WriteLine("Попробуй еще раз, мой любопытный товарисч");
                    }
                  else 
                   {
                         Console.WriteLine(operand1 / operand2);
                    }
         break;

         
         default:
             Console.WriteLine("WARNING!!! Прекращай это вытворять, выбери действие!");
             break;
        }*/
        // не надо пользоваться int, если только не хочешь получить целые числа в результате деления
        
           Console.WriteLine("Задание 4");
           Console.WriteLine("Введи пальчиком число от 1 до 100");
           int number = int.Parse(Console.ReadLine());
           if (number>=0 && number<=14)
           {
               Console.WriteLine("Введенное число находится в промежутке от 0 до 14");
           }
           else if (number>=15 && number<=35)
           {
               Console.WriteLine("Введенное число находится в промежутке от 15 до 35");
           }
           else if (number>=36 && number<=50)
           {
               Console.WriteLine("Введенное число находится в промежутке от 36 до 50");
           }
           else if (number>=50 && number<=100)
           {
               Console.WriteLine("Введенное число находится в промежутке от 50 до 100");
           }
           else{
               Console.WriteLine("Просили ж тыкать пальчиком всего от 0 до 100, ну :( ");
           }
        }   
    }
}