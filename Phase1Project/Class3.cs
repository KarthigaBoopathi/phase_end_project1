using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    class OneDayTeam : Player, ITeam
    {
        public static List<Player> oneday = new List<Player>();
        public OneDayTeam()
        {
            oneday.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneday.Add(player);
        }
        public void Remove(int playerId)
        {
            Player p = null;

            foreach (var s in oneday)
            {
                if (s.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", s.PlayerId);
                    p = s;
                }
            }

            oneday.Remove(p);
        }
        public Player GetPlayerById(int playerId)
        {
            Player p = null;

            foreach (var s in oneday)
            {
                if (s.PlayerId == playerId)
                {
                    p = s;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Id Not Found");
                }
            }
            return p;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player p = null;

            foreach (var s in oneday)
            {
                if (s.PlayerName == playerName)
                {
                    p = s;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name Not Found");
                }
            }
            return p;
        }

        public List<Player> GetAllPlayers()
        {
            return oneday;
        }
    }
}
