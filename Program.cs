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
                "Including even and odd numbers";
Console.WriteLine(result);

// Task2
Console.WriteLine("Enter x, y and z: ");
string x = Console.ReadLine();
int intX;
if (int.TryParse(x, out intX))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}
string y = Console.ReadLine();
int intY;
if (int.TryParse(y, out intY))
{ }
else
{
    Console.WriteLine("Failed to parse string value to integer value.");
}
string z = Console.ReadLine();
int intZ;
if (int.TryParse(z, out intZ))
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
double a = Math.Pow(intX, 2) / Factorial(2) + Math.Pow(intX, 4) / Factorial(4) + Math.Pow(intX, 6) / Factorial(6);
double b = Math.Sin(3 * Math.PI / 4) + intX * Math.Cos(intZ) - intZ * Math.Cos(intY) + intY * Math.Cos(intX);
double c = 5 * (intX * Math.Cos(intZ) - intZ * Math.Cos(intY) + intY * Math.Cos(intX));

Console.WriteLine("a = {0:n5} b = {1:n5} c = {2:n5}", a, b, c);
double maxAndMin = Math.Max(a, Math.Min(b, c));
Console.WriteLine("{0:n5}", maxAndMin);

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

int lenOfVect = vect.Length;
Console.WriteLine("Vector: ");
for(int i = 0; i < vect.Length; i++)
{
    Console.Write(vect[i] + " ");
}

int minIndex = Array.IndexOf(vect, vect.Min());
Console.WriteLine("\nIndex of min element of vector is: " + minIndex);
