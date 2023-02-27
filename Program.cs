//Console.WriteLine("Enter x: ");
//double x = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter y: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter z: ");
//double z = double.Parse(Console.ReadLine());

//double a = Math.Sin(x) * Math.Cos(y) - 1;
//double b = Math.Cos(x) * Math.Sin(y) + 2;
//double c = Math.Sin(x + y) - Math.Tan(z);

//double res = Math.Max(Math.Min(a, b), Math.Min(10, c));

//Console.WriteLine($"a = {a}");
//Console.WriteLine($"b = {b}");
//Console.WriteLine($"c = {c}");
//Console.WriteLine($"Result of max(min(a, b), min(10, c): {res}");

//Console.WriteLine("Enter n: ");
//int n = int.Parse(Console.ReadLine());
//int temp;
//string res = "";

//while(n >= 3)
//{
//    temp = n % 3;
//    res += temp;
//    n = n / 3;
//}

//if (n < 3)
//{
//    res += n;
//}

//string result = new string(res.Reverse().ToArray());
//Console.WriteLine($"Result: {result}");

// Створення матриці
System.Random random = new System.Random();

int n = 5;
int m = 4;

int[,] array = new int[n, m];

for (int i = 0; i < n; ++i)
    for (int j = 0; j < m; ++j)
        array[i, j] = random.Next(20);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(string.Format("{0} ", array[i, j]));
    }
    Console.Write(Environment.NewLine + Environment.NewLine);
}

// Створення вектора
double[] b = new double[n];
for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] != 0)
        {
            sum += array[i, j];
            count++;
        }
    }
    if (count > 0)
    {
        b[i] = sum / count;
    }
}

// Виведення вектора b
Console.WriteLine("Вектор b:");
for (int i = 0; i < b.Length; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();

// Перевірка, чи впорядкований вектор b за спаданням
bool isDescending = true;
for (int i = 0; i < b.Length - 1; i++)
{
    if (b[i] < b[i + 1])
    {
        isDescending = false;
        break;
    }
}
if (isDescending)
{
    Console.WriteLine("Вектор b впорядкований за спаданням");
}
else
{
    Console.WriteLine("Вектор b не впорядкований за спаданням");
}
