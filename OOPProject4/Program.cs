Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{number} * {i} = {number * i}");
}