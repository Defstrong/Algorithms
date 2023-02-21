using System.Collections;
using Algorithms.Algorithms;

int findNumber = int.Parse(Console.ReadLine());
var array = new int[] { 1, 5, 7, 12, 14, 15, 17, 18, 19, 110 };

Console.WriteLine(array.RecursiveBinarySearch(0, array.Length, findNumber).idxFindVal+1);