using System.Linq;

// Методы
// Напечатать массив
void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}]");
            break;
        }
        Console.Write($"{array[i]}, ");
    }
}

// -----------------------------------------------------------------------------------

// Создание пользователем массива str
string[] GetStringArrayFromUser(string elements)
{
    string[] array = elements.Split(' ').Select(x => x).ToArray();
    return array;
}
Console.WriteLine("Введите любые строки через пробел: ");

// -----------------------------------------------------------------------------------

// Удаление из массива элементов размер которых, больше трех символов
string[] DelElementsHigherThree(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) 
        {
            array = array.Where((sourse, index) =>index != i).ToArray();
            i--;
        }
    }

    return array;
} 

// -----------------------------------------------------------------------------------