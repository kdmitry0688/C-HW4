Console.WriteLine("Введите число ");
double Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в которую необходимо возвести число ");
double Expon = Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow(Number, Expon);

Console.WriteLine(pow);