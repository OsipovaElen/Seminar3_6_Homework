//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент для линии А: ");
double kofA = GetDoubleInput();
Console.WriteLine("Введите константу для линии А: ");
double konstA = GetDoubleInput();
Console.WriteLine("Введите коэффициент для линии Б: ");
double kofB = GetDoubleInput();
Console.WriteLine("Введите константу для линии Б: ");
double konstB = GetDoubleInput();

double[] coord = new double[2];

double GetDoubleInput()
{
    string input = Console.ReadLine();
    double result = Convert.ToDouble(input);
    return result;
}

GetCoord(kofA, konstA, kofB, konstB);
void GetCoord(double kofA, double konstA, double kofB, double konstB)
{
    if (kofA == kofB)
    {
        if (konstA ==konstB)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
    else
    {
        coord[0] = Math.Round((konstA - konstB) / (kofB - kofA), 2);
        coord[1] = Math.Round((kofA * ((konstA - konstB) / (kofB - kofA))) +  konstA, 2);
        Console.WriteLine($"Точка пересечения имеет координаты ({coord[0]}, {coord[1]})");
    }
}
