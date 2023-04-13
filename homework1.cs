//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 


Console.WriteLine("Введите число М - сколько вы хотите ввести чисел: ");
int inputM = GetIntInput();
int[] array = new int[inputM];
int sum = 0;
for (int i = 0; i < inputM; i++) 
{
    Console.WriteLine("Введите число: ");
    array[i] = GetIntInput();
    if (array[i] > 0)
    {
        sum++; 
    }
}

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
Console.WriteLine($"Введено {sum} положительных чисел");