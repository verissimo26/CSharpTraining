int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine()); 
}

double sum = 0;
for (int i = 0;i < n; i++)
    sum += vect[i];

double AVG = sum / n;

Console.WriteLine(AVG.ToString("F2"));