using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace QuickSortApp
{
       class Program
       {
              static void Main(string[] args)
              {
                     // create a new list to hold some random integers
                     List<int> list = new List<int>();
 
                     // create a new random number generator
                     Random rng = new Random();
 
                     // Put 20 random integers in the list
                     for (int i = 0; i < 20; i++)
                     {
                           list.Add(rng.Next(20));
                     }
 
                     PrintList(list);
 
                     Console.WriteLine("Press any key to sort!");
                     Console.ReadKey();
 
                     // sort the list!
                     Console.WriteLine("Sorting...");
                     List<int> sortedList = QuickSort(list);
                     PrintList(sortedList);

                     Console.ReadKey();
              }
 
              private static void PrintList(List<int> list)
              {
                     Console.WriteLine("Here is the list:");
                     for (int i = 0; i < list.Count; i++)
                     {
                           Console.WriteLine(list[i]);
                     }
                     Console.WriteLine();
              }
 
              static List<int> QuickSort(List<int> unsortedList)
              {
                     List<int> sortedList = new List<int>();
 
                     // first, check the size of the list - if it's zero or one items long, it's considered sorted!
                     if (unsortedList.Count == 0 || unsortedList.Count == 1)
                     {
                           sortedList = unsortedList;
                     }
                     else
                     {
                           // pick a pivot
                           int pivot = unsortedList[0];
 
                           // make a list for all smaller items
                           List<int> leftList = new List<int>();
                           // make a list for all larger items
                           List<int> rightList = new List<int>();
 
                           // loop through all numbers in the list, and put each smaller item in the left
                           // list and each larger (or equal) item in the right list.
                           // Start at 1 so we don't duplicate the pivot!
                           for (int i = 1; i < unsortedList.Count; i++)
                           {
                                  int item = unsortedList[i];
                                  if (item < pivot)
                                  {
                                         leftList.Add(item);
                                  }
                                  else
                                  {
                                         rightList.Add(item);
                                  }
                           }
 
                           // sort the left
                           List<int> leftSortedList = QuickSort(leftList);
                           // sort the right
                           List<int> rightSortedList = QuickSort(rightList);
 
                           // add everything from left list
                           sortedList.AddRange(leftSortedList);
                           // add pivot
                           sortedList.Add(pivot);
                           // add everything from right list
                           sortedList.AddRange(rightSortedList);
                     }
 
                     return sortedList;
              }
       }
}
