using Lab1;

Console.Write("Enter degree of accuracy: ");
var power = Console.ReadLine();

double[,] A =
{
    {0.38,- 0.05, 0.01, 0.02, 0.07 },
    {0.052, 0.595, 0 , - 0.04, 0.04 },
    {0.03, 0, 0.478, - 0.14 ,0.08 },
    { -0.06, 0.126, 0 ,0.47,- 0.02},
    { 0.25, 0 ,0.09, 0.01, 0.56}
};
double[] f = [2.32, 2.544, -3.238, 1.534, 0.12];
double[] x = [0, 0, 0, 0, 0];
var e = Convert.ToDouble($"1E-{power}");

GaussIterationMethod.IterationFunction(A, f, x, e);