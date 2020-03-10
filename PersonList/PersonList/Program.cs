using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List.Add(new Person {personName = "Angelica", personAge = "23"});
            List.Add(new Person {personName = "Jarrod", personAge = "23"});
            List.Add(new Person {personName = "Yolanda", personAge = "57"});
            List.Add(new Person {personName = "David", personAge = "16"});
            List.Add(new Person {personName = "David", personAge = "59"});

            var duplicate = new List<string>();
            if (duplicate.Contains(personName))
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        static void InsertionSort(List<Person> persons)
        {
            for ( int i = 0; i< persons.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    persons.Remove(personName);
                    persons.Insert(j, personName);
                    break;
                }
            }
        }
    }    

    

}



// Answer to 9: in bubble sort, you must first cycle through entire array
// if the first index is larger than the second index it will swap those two. If not it will check the next set of adjacent numbers
// once it cycles through the whole array without swapping it will be done sorting
// in insertion sort, we must assume there are two arrays, one sorted and one unsorted. intiially the sorted array is empty
// then we iterate over the elements of the unsorted array, and place them in the sorted array until all elements have been sorted from one array to the sorted array. 


// 6. In the Program class, create a List of at least five Persons, and use Console to show the user
//    the List's contents.
// 7. Implement a method that will efficiently check for any duplicate names in a List of Persons,
//    returning true or false.
// 8. Implement a method that will sort a List of Persons by name, using *insertion sort*.
// 9. In a comment, describe the difference between insertion sort and bubble sort.
// 10. Call these two methods on the created List and use Console to show the user the results.