using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();


            while (command != "Retire!")
            {
                string[] toDo = command.Split(" - ");
                string action = toDo[0];
                string content = toDo[1];

                string[] sideQuest = content.Split(":");
                string questToCheck = sideQuest[0];




                for (int i = 0; i < commands.Count; i++)
                {

                    if (action == "Start")
                    {
                        if (!commands.Contains(content))
                        {
                            commands.Add(content);
                        }


                    }


                    if (action == "Complete")
                    {
                        if (content == commands[i])
                        {

                            commands.Remove(commands[i]);

                        }

                    }
                    if (action == "Side Quest")
                    {
                        string questToAdd = sideQuest[1];

                        if (questToCheck == commands[i] && !commands.Contains(questToAdd))
                        {

                            commands.Insert(i + 1, questToAdd);

                        }

                    }
                    if (action == "Renew")
                    {
                        if (content == commands[i])
                        {
                            commands.Add(commands[i]);
                            commands.Remove(commands[i]);

                        }
                    }

                }

                command = Console.ReadLine();


            }
            Console.WriteLine(string.Join(", ", commands));
        }
    }
}
