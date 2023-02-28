// Task1
Console.WriteLine("Enter the number: ");
string n = Console.ReadLine();
int intN;
if (int.TryParse(n, out intN))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}
int evenDigits = 0;
int oddDigits = 0;

while (intN > 0)
{
    int digit = intN % 10;
    if (digit % 2 == 0)
    {
        evenDigits++;
    }
    else
    {
        oddDigits++;
    }
    intN /= 10;
}

string result = (evenDigits > oddDigits) ? "Number has more even numbers" :
                (oddDigits > evenDigits) ? "Number has more odd numbers" :
                "The same number of even and odd numbers";
Console.WriteLine(result);

// Task2
Console.WriteLine("Enter x, y and z: ");
string x = Console.ReadLine();
double doubleX;
if (double.TryParse(x, out doubleX))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}
string y = Console.ReadLine();
double doubleY;
if (double.TryParse(y, out doubleY))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}
string z = Console.ReadLine();
double doubleZ;
if (double.TryParse(z, out doubleZ))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}

static int Factorial(int n)
{
    int temp = 1;
    for (int i = 2; i <= n; i++)
    {
        temp *= i;
    }
    return temp;
}
double a = Math.Pow(doubleX, 2) / Factorial(2) + Math.Pow(doubleX, 4) / Factorial(4) + Math.Pow(doubleX, 6) / Factorial(6);
double b = Math.Sin(3 * Math.PI / 4) + doubleX * Math.Cos(doubleZ) - doubleZ * Math.Cos(doubleY) + doubleY * Math.Cos(doubleX);
double c = 5 * (doubleX * Math.Cos(doubleZ) - doubleZ * Math.Cos(doubleY) + doubleY * Math.Cos(doubleX));

Console.WriteLine("a = {0:n5} b = {1:n5} c = {2:n5}", a, b, c);
double maxAndMin = Math.Max(a, Math.Min(b, c));
Console.WriteLine("max between a and min(b,c): {0:n5}", maxAndMin);

// Task3
int[,] matrix = new int[5, 6];
Console.Write("------------------------------------------------------\n");
Console.Write("Input elements in the matrix :\n");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write("element - [{0},{1}] : ", i, j);
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("\nThe matrix is : \n");
for (int i = 0; i < 5; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 6; j++)
        Console.Write("{0}\t", matrix[i, j]);
}
Console.Write("\n\n");

int[] vect = new int[5];
for (int i = 0; i < 5; i++)
{
    int max = matrix[i, 0];
    for (int j = 1; j < 6; j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    vect[i] = max;
}

Console.WriteLine("Vector: ");
for(int i = 0; i < vect.Length; i++)
{
    Console.Write(vect[i] + " ");
}

int minIndex = Array.IndexOf(vect, vect.Min());
Console.WriteLine("\nIndex of min element of vector is: " + minIndex);
