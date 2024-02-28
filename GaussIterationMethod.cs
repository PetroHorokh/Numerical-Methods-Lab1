namespace Lab1;

public static class GaussIterationMethod
{
    public static void IterationFunction(double[,] A, double[] f, double[] x, double e)
    {
        int counter = 0;
        int n = x.Length;
        double norm;
        double[] incoherency, multiplication, subtraction;
        double[] priorX = new double[n];
        do
        {
            norm = 0;

            Array.Copy(x, priorX, n);

            multiplication = Multiply(A, x);

            subtraction = Subtraction(x, multiplication);

            x = Add(subtraction, f);

            for (int i = 0; i < n; i++)
            {
                norm += Math.Pow(x[i] - priorX[i], 2);
            }

            norm = Math.Sqrt(norm);

            counter++;

            incoherency = Subtraction(multiplication, f);

        } while (norm >= e);

        Console.WriteLine($"Accuracy: {e}");
        Console.WriteLine($"Iteration quantity: {counter}");
        Console.WriteLine("\nResult:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"х[{(i + 1)}] = {x[i]}");
        }

        Console.WriteLine("\nIncoherency vector:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"r[{(i + 1)}] = {incoherency[i]}");
        }
    }
    public static double[] Multiply(double[,] matrixA, double[] matrixB)
    {
        double[] result = new double[matrixA.GetLength(0)];
        int n = matrixA.GetLength(0);
        int m = matrixA.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            double sum = 0;

            for (int j = 0; j < m; j++)
            {
                sum += matrixA[i, j] * matrixB[j];
            }

            result[i] = sum;
        }

        return result;
    }
    public static double[] Subtraction(double[] arrayA, double[] arrayB)
    {
        double[] result = new double[arrayA.Length];

        for (int i = 0; i < arrayA.Length; i++)
        {
            result[i] = arrayA[i] - arrayB[i];
        }

        return result;
    }
    public static double[] Add(double[] arrayA, double[] arrayB)
    {
        var result = new double[arrayA.Length];

        for (int i = 0; i < arrayA.Length; i++)
        {
            result[i] = arrayA[i] + arrayB[i];
        }

        return result;
    }
}