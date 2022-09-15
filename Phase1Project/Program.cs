using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Phase1Project
{
    public class Program
    {
        static void Main(string[] args)
        {

             start:
             Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
             int option= Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        OneDayTeam od= new OneDayTeam();
                        if (OneDayTeam.oneday.Count <= OneDayTeam.oneday.Capacity)
                        {
                            Console.WriteLine("Enter Player Id:");
                            od.PlayerId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Player Name:");
                            od.PlayerName = Console.ReadLine();
                            Console.WriteLine("Enter Player Age:");
                            od.PlayerAge = Convert.ToInt32(Console.ReadLine());
                            od.Add(od);
                            Console.WriteLine("Player added Successfully!!");
                        }
                        else
                        {
                            Console.WriteLine("More than 11 Players can't be added to team..");
                        }
                        break;

                    case 2:
                        OneDayTeam od1 = new OneDayTeam();
                        Console.WriteLine("Enter Player Id to Remove:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        od1.Remove(id);
                        break;

                    case 3:
                        OneDayTeam od2 = new OneDayTeam();
                        Console.WriteLine("Enter Player Id:");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Player p = od2.GetPlayerById(id1);
                        Console.WriteLine("Player Id: " + p.PlayerId);
                        Console.WriteLine("Player Name: " + p.PlayerName);
                        Console.WriteLine("Player Age: " + p.PlayerAge);
                        break;

                    case 4:
                        OneDayTeam od3 = new OneDayTeam();
                        Console.WriteLine("Enter Player Name:");
                        string name = Console.ReadLine();
                        Player p1 = od3.GetPlayerByName(name);
                        Console.WriteLine("Player Id: " + p1.PlayerId);
                        Console.WriteLine("Player Name: " + p1.PlayerName);
                        Console.WriteLine("Player Age: " + p1.PlayerAge);
                        break;

                    case 5:
                        Console.WriteLine("All Players Details:");
                        List<Player> all = new List<Player>();
                        OneDayTeam od4 = new OneDayTeam();
                        all = od4.GetAllPlayers();
                        foreach (var item in all)
                        {
                            Console.WriteLine("Player Id: " + item.PlayerId);
                            Console.WriteLine("Player Name: " + item.PlayerName);
                            Console.WriteLine("Player Age: " + item.PlayerAge);
                        }
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine("Do you want to continue (yes/no)?");
                string s1= Console.ReadLine();
                if (s1 == "yes")
                {
                    goto start;
                }
                else if (s1 == "no")
                {
                    Environment.Exit(0);
                }
            
            Console.ReadLine();
        }
    }
    }

