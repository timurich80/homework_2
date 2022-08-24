Console.WriteLine("Введите ваше первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
a = (a/10) % 10;
Console.Write(a);

