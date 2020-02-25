using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contactList = Console.ReadLine().Split().ToList();
            string contact = string.Empty;
            string[] tokens;
            int contactIndex = 0;
            int count = 0;
            string task = string.Empty;
            string command = Console.ReadLine();
            while (command != "Print")
            {
                tokens = command.Split();
                task = tokens[0];
                if (task == "Add")
                {
                    contact = tokens[1];
                    contactIndex = int.Parse(tokens[2]);
                    if (contactList.Contains(contact) && contactIndex <= contactList.Count && contactIndex >= 0)
                    {
                        contactList.Insert(contactIndex, contact);
                    }
                    else
                    {
                        if (contactIndex > 0)
                        {

                            contactList.Add(contact);
                        }
                    }
                }
                else if (task == "Remove")
                {
                    contactIndex = int.Parse(tokens[1]);
                    if (contactIndex < contactList.Count && contactIndex >= 0)
                    {
                        contactList.RemoveAt(contactIndex);
                    }
                }
                else if (task == "Export")
                {
                    if (contactIndex >= 0 && count >= 0)
                    {
                        contactIndex = int.Parse(tokens[1]);
                        count = int.Parse(tokens[2]);
                        List<string> exportContacts = new List<string>();
                        for (int i = contactIndex; i < count + contactIndex; i++)
                        {
                            if (i >= contactList.Count)
                            {
                                break;
                            }
                            exportContacts.Add(contactList[i]);
                        }
                        Console.WriteLine(string.Join(" ", exportContacts));
                    }

                }
                if (task == "Print")
                {
                    if (tokens[1] == "Normal")
                    {
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contactList));
                        break;
                    }
                    if (tokens[1] == "Reversed")
                    {
                        contactList.Reverse();
                        Console.Write("Contacts: ");
                        Console.WriteLine(string.Join(" ", contactList));
                        break;
                    }

                }
                command = Console.ReadLine();
            }
        }
    }
}
