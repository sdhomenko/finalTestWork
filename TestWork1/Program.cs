//Написать программу, которая из имеющегося массива строк формитрует массив из строк, 
//длина которых меньше либо равна 3 символа.

//Создаем массив из строк
string[] CreateStringsMassive()
{

    Console.Write("Задайте размер массива: ");
    int s = Convert.ToInt32(Console.ReadLine());
    string[] result = new string[s];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

//Печать массива
void PrintMassive(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.Write($"{text[i]} ");
    }
}

string[] text = CreateStringsMassive();
Console.WriteLine();
PrintMassive (text);
