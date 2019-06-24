using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entry> entries = new List<Entry>
            {
                new Entry{name = "Diego", LastName = "Ambriz"},
                new Entry{name = "Jorge", LastName = "Perez"},
                new Entry{name = "Luis", LastName = "Garcia"},
                new Entry{name = "Guillermo", LastName = "Del Toro"},
                new Entry{name = "Tom", LastName = "Holland"}
            };
            entries.Sort((entry1, entry2) => $"{entry1.name}{entry1.LastName}".CompareTo($"{entry2.name}{entry2.LastName}"));
            //entries.Sort(CompareEntries);
            /*entries.Sort(delegate (Entry entry1, Entry entry2) Metodo Anonimo
            {
                return $"{entry1.name}{entry1.LastName}".CompareTo($"{entry2.LastName}{entry2.LastName}");
            });*/
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.name + " " + entry.LastName);
            }
            Console.ReadLine();
        }

        /*private static int CompareEntries(Entry entry1, Entry entry2)
        {
            return $"{entry1.name}{entry1.LastName}".CompareTo($"{entry2.LastName}{entry2.LastName}");
        }*/
    }
}
