Console.WriteLine("Добро пожаловать! Для начала работы необходимо ввести 10 целых чисел. \n Каждое число необходимо вводить с новой строки");
int[] numbers = new int[10];
int sum = 0;

for(int i=0; i<=9; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    numbers[i] = num;
    //Суммирование всех чисел
    sum += num;
}
int avg = sum/10;

int min = numbers[0];
int max = numbers[0];
int even_numbers = 0;
int odd_numbers = 0;
string a = null;

foreach (int n in numbers)
{
    //условие для минимального значения
    if (n < min)
    {
        min = n;
    }
    //условие для максимального значения
    if(n > max)
    {
        max = n;
    }

    //условие для определения четности чисел
    if (n % 2 == 0)
    {
        even_numbers++;
    }
    else 
    { 
        odd_numbers++; 
    }

    //запись чисел, которые больше среднего арифметического
    if (n > avg)
    {
        a += Convert.ToString(n) + " ";
    }
}

Console.WriteLine("Сумма всех введенных чисел: " + Convert.ToString(sum));
Console.WriteLine("Среднее арифметическое значение всех введенных чисел: " + Convert.ToString(avg));
Console.WriteLine("Минимальное значение из всех введенных чисел: " + Convert.ToString(min));
Console.WriteLine("Максимальное значение из всех введенных чисел: " + Convert.ToString(max));
Console.WriteLine("Количество четных чисел: " + Convert.ToString(even_numbers));
Console.WriteLine("Количество нечетных чисел: " + Convert.ToString(odd_numbers));
Console.WriteLine("Числа, которые больше среднего арифметического: " + a);