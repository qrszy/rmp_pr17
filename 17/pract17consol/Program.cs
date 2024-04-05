using pract17;
using System.Reflection.Metadata;
using System.IO;

int s = 0; bool X=false; string str;int A=0;

do
{
    try { 
        Console.WriteLine("Вам нужна книга(1) или учебник(2)?");
        s = Convert.ToInt32(Console.ReadLine());
        if (s == 1)
        {
            Fiction fiction = new Fiction();
            do
            {
                Console.WriteLine("Введите название");
                str = Console.ReadLine();
                Bukvi(str, out X);
            } while (X != true);
            fiction.Nick = str;
            do
            {
                Console.WriteLine("Введите нэйм автора");
                str = Console.ReadLine();
                fiction.Bukvi(str, out X);
            } while (X != true);
            fiction.Avtor = str;
            X = false;
            do
            {
                try { 
                Console.WriteLine("Введите год выпуска");
                A = Convert.ToInt32(Console.ReadLine());
                str = A.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsNumber(str[i])) X = false;
                }
                }
                catch { Console.WriteLine("Введён неизвестый символ"); }
            } while (X == true);
            fiction.Godvipuska = A;
            X = false;
            do
            {
                Console.WriteLine("Введите имеющиеся картинки");
                str = Console.ReadLine();
                fiction.Bukvi(str, out X);
            } while (X != true);
            fiction.Kartinki = str;
            X = false;
            do
            {
                Console.WriteLine("Введите жанр книги");
                str = Console.ReadLine();
                fiction.Bukvi(str, out X);
            } while (X != true);
            fiction.Janr = str;
            Console.WriteLine(fiction.Info()); 
        }
        else
            if (s == 2)
        {
            Tutorial tutorial = new Tutorial();
            do
            {
                Console.WriteLine("Введите название");
                str = Console.ReadLine();
                str.Bukvi(str, out X);
            } while (X != true);
            tutorial.Nick = str;
            do
            {
                Console.WriteLine("Введите нэйм автора");
                str = Console.ReadLine();
                tutorial.Bukvi(str, out X);
            } while (X != true);
            tutorial.Avtor = str;
            X = false;
            do
            {
                try { 
                Console.WriteLine("Введите год выпуска");
                A = Convert.ToInt32(Console.ReadLine());
                str = A.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsNumber(str[i])) X = false;
                }
                }
                catch { Console.WriteLine("Введён неизвестый символ"); }
            } while (X == true);
            tutorial.Godvipuska = A;
            do
            {
                Console.WriteLine("Введите имеющиеся картинки");
                str = Console.ReadLine();
                tutorial.Bukvi(str, out X);
            } while (X != true);
            tutorial.Kartinki = str;
            do
            {
                try { 
                Console.WriteLine("Введите кол-во экземпляров");
                A = Convert.ToInt32(Console.ReadLine());
                str = A.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsNumber(str[i])) X = false;
                }
                }
                catch { Console.WriteLine("Введён неизвестый символ"); }
            } while (X == true);
            tutorial.Kolekzemp = A;
            do
            {
                Console.WriteLine("Введите предметную область");
                str = Console.ReadLine();
                tutorial.Bukvi(str, out X);
            } while (X != true);
            tutorial.Kartinki = str;
            Console.WriteLine(tutorial.Info());
        }
    }
    catch { Console.WriteLine("Введён неизвестый символ"); }
} while (s != 1 || s != 2);
 static bool Bukvi(string x, out bool X)
{
    X = true;
    if (x != "")
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (!Char.IsLetter(x[i])) X = false;
        }
        return X;
    }
    else
    {
        X = false;
        return X;
    }
}