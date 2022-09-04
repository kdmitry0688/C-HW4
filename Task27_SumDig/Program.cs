Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int SumNumbers(string number)
{   int result = 0;

    for (int i = 0; i < number.Length; i++)
    {
        result += number[i] - '0';
    }
    
    return result; 
}
Console.WriteLine("Сумма цифр данного числа равна " + SumNumbers(number));