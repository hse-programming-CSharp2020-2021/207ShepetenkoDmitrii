/*
 Известно, что люди ленивы, поэтому они часто используют шаблоны для написания текстов.
В шаблонах содержатся определенные магические последовательности, которые должны быть автоматически заменены на содержимое
в итоговом варианте текста. Так случилось и в этот раз: перед вами поставили задачу заменить в тексте шаблона все подстановки
вида #Goods[Code1;Code2;Code3]# на список товаров с их ценами. Т.е. Code1 – это уникальный артикул первого товара,
Code2 – второго и т.п. (количество товаров может быть любым, цену генерируйте случайным образом в подходящем диапазоне).

 var html = "Тут сначала что-то написано. Товары #Goods[Code1;Code2;Code3]# + еще какой-то текст #Goods[Code5;Code6]# ну и финалочка...";
 */
using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = "Тут сначала что-то написано. Товары #Goods[Code1;Code2;Code3]# + еще какой-то текст #Goods[Code5;Code6]# ну и финалочка...";

            Random rnd = new Random();
            Regex r = new Regex(@"#Goods\[(.*?)\]#");
            foreach (Match i in r.Matches(html))
                foreach (string s in i.Groups[1].Value.Split(';'))
                    Console.WriteLine($"Цена за {s} = {rnd.Next(10, 40)} руб.");
                
        }
    }
}
