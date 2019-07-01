using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());

            List<Team> listOfTeams = GetListOfTeams(teamsToRegister);
            listOfTeams = AddMembers(listOfTeams);
            var orderedList = GetOrderedList(listOfTeams);
            PrintRealTeams(orderedList);
        }

        static void PrintRealTeams(List<Team> orderedList)
        {
            foreach (var team in orderedList.Where(m => m.TeamMembers.Count > 0))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.TeamCreator}");
                foreach (var tm in team.TeamMembers.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {tm}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var team in orderedList.Where(m => m.TeamMembers.Count == 0))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }

        static List<Team> AddMembers(List<Team> listOfTeams)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end of assignment")
                    break;
                string[] separator = new string[] { "->" };
                var currentLine = inputLine.Split(separator, StringSplitOptions.None).ToList();
                var memberName = currentLine.First();
                var clubName = currentLine.Last();
                var currentTeam = listOfTeams.FirstOrDefault(n => n.TeamName == clubName);
                if (!listOfTeams.Any(t => t.TeamName == clubName))
                {
                    Console.WriteLine($"Team {clubName} does not exist!");
                    continue;
                }
                else if (listOfTeams.Any(n => n.TeamMembers.Contains(memberName))
                    || listOfTeams.Any(cr => cr.TeamCreator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {clubName}!");
                    continue;
                }
                else
                {
                    currentTeam.TeamMembers.Add(memberName);
                }
            }
            return listOfTeams;
        }


        static List<Team> GetOrderedList(List<Team> listOfTeams)
        {
            return listOfTeams.OrderByDescending(a => a.TeamMembers.Count).ThenBy(n => n.TeamName).ToList();
        }



        static List<Team> GetListOfTeams(int teamsToRegister)
        {
            var listOfTeams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                var input = Console.ReadLine().Split('-').ToList();
                var creatorName = input.First();
                var teamName = input.Last();

                if (listOfTeams.Any(n => n.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (listOfTeams.Any(c => c.TeamCreator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                else
                {
                    var newTeam = new Team
                    {
                        TeamName = teamName,
                        TeamCreator = creatorName,
                        TeamMembers = new List<string>()
                    };
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    listOfTeams.Add(newTeam);
                }
            }
            return listOfTeams;
        }
    }
}
