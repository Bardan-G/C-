Console.WriteLine("Enter any Number");

int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
    Console.WriteLine($"The sum of number 1 to {n} is {sum}");
}

int num = 1;

while (num <= 20)
{
    if (num % 4 == 0)
    {
        num++;
        continue;
    }
    if (num == 15)
        break;
    
    Console.WriteLine(num);
    num++;
}

int[] numbers = { 2, 4, 6, 8, 10 };
int total = 0;

foreach (int numInArray in numbers)
{
    total += numInArray;
}

Console.WriteLine($"The sum of the array elements is {total}");

    

