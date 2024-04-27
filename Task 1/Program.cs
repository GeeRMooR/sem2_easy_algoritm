// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите целое трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Неккоректный ввод");
}