﻿using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
        => n > 0 && n < 65 ? (ulong)Math.Pow(2, n - 1) : throw new System.ArgumentOutOfRangeException();

    public static ulong Total()
        => Enumerable.Range(1,64).Aggregate(0UL, (acc, n) => acc + Square(n));
    
}
