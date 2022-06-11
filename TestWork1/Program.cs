//Написать программу, которая из имеющегося массива строк 
//формитрует массив из строк, длина которых меньше либо равна 3 символа.

//Создаем массив из строк
string[] CreateStringsMassive()
{
    Console.Write("Задайте размер массива: ");
    int s = Convert.ToInt32(Console.ReadLine());
    string[] result = new string[s];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] OptimizeMassive(string[] text)
{
    string[] newtext = new string[text.Length];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3) newtext[i - count] = text[i];
        else count++;
    }
    Array.Resize(ref newtext, text.Length - count);
    return newtext;
}

//Печать массива
void PrintMassive(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.Write($"'{text[i]}' ");
    }
    Console.WriteLine();
}

string[] text = CreateStringsMassive();
Console.WriteLine("Заданный массив");
PrintMassive(text);
string[] newtext = OptimizeMassive(text);
Console.WriteLine("Итоговый массив");
PrintMassive(newtext);