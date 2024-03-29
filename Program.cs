﻿using Lab1;

double[,] A =
{
    {.38, -.05, .01, .02, .07 },
    {.052, .595, 0, -.04, 0.04 },
    {.03, 0, .478, -.14 , .08 },
    {-.06, .126, 0, .47, -.02},
    {.25, 0, .09, .01, .56}
};
double[] f = [2.32, 2.544, -3.238, 1.534, 0.12];
var e = 1E-10;

GaussIterationMethod.IterationFunction(A, f, e);