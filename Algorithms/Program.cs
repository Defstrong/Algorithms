using System.Collections;
using Algorithms.Algorithms;

int findNumber = int.Parse(Console.ReadLine());
var array = new int[] { 1, 5, 7, 12, 14, 15, 17, 18, 19, 110 };

var final = array.BinarySearch(findNumber);

if (final.haveOrNot)
    Console.WriteLine(final.idxFindVal + 1);
else
    Console.WriteLine("Error 404. Not found!!!");