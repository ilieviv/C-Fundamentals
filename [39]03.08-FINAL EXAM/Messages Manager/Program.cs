using System;
using System.Collections.Generic;
using System.Linq;
namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Dictionary<string, int> sentMessages = new Dictionary<string, int>();
            Dictionary<string, int> receivedMessages = new Dictionary<string, int>();
            Dictionary<string, int> allMessages = new Dictionary<string, int>();

            while (input != "Statistics")
            {
                string[] splittedInput = input.Split("=");
                string command = splittedInput[0];

                if (command == "Add")
                {
                    string username = splittedInput[1];
                    int sent = int.Parse(splittedInput[2]);
                    int received = int.Parse(splittedInput[3]);

                    if (!(sentMessages.ContainsKey(username) && receivedMessages.ContainsKey(username)))
                    {
                        sentMessages.Add(username, sent);
                        receivedMessages.Add(username, received);
                    }

                }
                else if (command == "Message")
                {
                    string sender = splittedInput[1];
                    string receiver = splittedInput[2];

                    if (sentMessages.ContainsKey(sender) && sentMessages.ContainsKey(receiver) && receivedMessages.ContainsKey(sender) && receivedMessages.ContainsKey(receiver))
                    {
                        sentMessages[sender] += 1;
                        receivedMessages[receiver] += 1;


                        if (sentMessages[sender]+receivedMessages[sender] >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            sentMessages.Remove(sender);
                            receivedMessages.Remove(sender);
                        }
                        if (receivedMessages[receiver]+sentMessages[receiver] >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            receivedMessages.Remove(receiver);
                            sentMessages.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string username = splittedInput[1];

                    if (sentMessages.ContainsKey(username) && receivedMessages.ContainsKey(username))
                    {
                        sentMessages.Remove(username);
                        receivedMessages.Remove(username);
                    }
                    else if (username == "All")
                    {
                        sentMessages.Clear();
                        receivedMessages.Clear();
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var user in receivedMessages.OrderByDescending(user => user.Value).ThenBy(user => user.Key))
            {
                foreach (var kvp in sentMessages)
                {
                    if (user.Key == kvp.Key)
                    {
                        int total = user.Value + kvp.Value;
                        allMessages.Add(user.Key, total);
                    }
                }
            }

            int userCount = allMessages.Count;
            Console.WriteLine($"Users count: {userCount}");

            foreach (var user in allMessages)
            {
                Console.WriteLine($"{user.Key} - {user.Value}");
            }
        }
    }
}
