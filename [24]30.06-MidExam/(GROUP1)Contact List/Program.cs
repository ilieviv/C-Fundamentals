using System;
using System.Linq;

namespace _GROUP1_Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var contacts = input.Split().ToList();


            var com = Console.ReadLine();
            while (true)
            {
                string[] command = com.Split();
                string operation = command[0];

                if (operation == "Add")
                {
                    string contact = command[1];
                    int index = int.Parse(command[2]);

                    if (!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                    }
                    else
                    {
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (operation == "Export")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);

                    for (int i = startIndex; i < startIndex + count; i++)
                    {
                        if (i >= contacts.Count)
                        {
                            break;
                        }

                        Console.Write(contacts[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if (operation == "Print")
                {
                    string norRev = command[1];

                    if (norRev == "Normal")
                    {
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contacts));
                        return;
                    }
                    else if (norRev == "Reversed")
                    {
                        contacts.Reverse();
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contacts));
                        return;
                    }
                }
                com = Console.ReadLine();
            }
        }
    }
}
