using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleGame
{
    class Weapons
    {

         
        static public void Main()
        {

            // Creating a dictionary 
            // using Dictionary<TKey,TValue> class 
            Dictionary<int, string> My_dict =
                         new Dictionary<int, string>();

            // Adding key/value pairs in the  
            // Dictionary Using Add() method 
            My_dict.Add(1, "Fish");
            My_dict.Add(2, "Frying pan");
            My_dict.Add(3, "Brick");
            My_dict.Add(4, "Crowbar");
            My_dict.Add(5, "Knife");
            My_dict.Add(6, "Sword");
            My_dict.Add(7, "Pistol");
            My_dict.Add(8, "Double-Barelled Shotgun");
            My_dict.Add(9, "Bomb");
            My_dict.Add(10, "Shield");



            for (int i = 1; i < 10; ++i)
            {
                int index = random.Next(dictionary.Count);

                //string key = dictionary.Keys.ElementAt(index);
                
                KeyValuePair<string, int> pair = Dictionary.ElementAt(index);

                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
            }
        }
    }
}

   