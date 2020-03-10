using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> usersLikesAndComments = new Dictionary<string, List<int>>();
            while (true)
            {
                var command = Console.ReadLine();
                var tokens = command.Split(": ");
                if (tokens[0] == "New follower")
                {
                    var username = tokens[1];
                    if (!usersLikesAndComments.ContainsKey(username))
                    {
                        usersLikesAndComments.Add(username, new List<int>());
                        usersLikesAndComments[username].Add(0); //likes
                        usersLikesAndComments[username].Add(0); //comments
                    }
                }
                else if (tokens[0] == "Like")
                {
                    var username = tokens[1];
                    var count = int.Parse((tokens[2]));
                    //here might be need check
                    if (!usersLikesAndComments.ContainsKey(username))
                    {
                        usersLikesAndComments.Add(username, new List<int>());
                        usersLikesAndComments[username].Add(count);
                        usersLikesAndComments[username].Add(0);
                    }
                    else 
                    {
                        usersLikesAndComments[username][0] += count;
                    }
                }
                else if (tokens[0] == "Comment")
                {
                    var username = tokens[1];

                    if (!usersLikesAndComments.ContainsKey(username))
                    {
                        usersLikesAndComments.Add(username, new List<int>());
                        usersLikesAndComments[username].Add(0);
                        usersLikesAndComments[username].Add(1);
                    }
                    else
                    {
                        usersLikesAndComments[username][1] += 1;
                    }
                }
                else if (tokens[0] == "Blocked")
                {
                    var username = tokens[1];
                    if (!usersLikesAndComments.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }

                    usersLikesAndComments.Remove(username);
                }
                else if (tokens[0] == "Log out")
                {
                    break;
                }
            }

            Console.WriteLine($"{usersLikesAndComments.Count} followers");
            foreach (var user in usersLikesAndComments.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
              //  var total = user.Value[0] + user.Value[1];
                Console.WriteLine($"{user.Key}: {user.Value.Sum()}");
            }
        }
    }
}
