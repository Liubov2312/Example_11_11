Console.WriteLine("2 Hello, World!");
Console.WriteLine("Week days!");
string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Today is {Days[index-1]}");



Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

while (b <= a)
{
    Console.Write(b + ", ");
    b++;
}
