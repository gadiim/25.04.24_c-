using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLibrary
{
    public class Player
    {
        private string PlayerName { get; set; }
        private string PlayerPosition { get; set; }
        private int PlayerNumber { get; set; }
        private int PlayerAge { get; set; }
        public Player (string name, string position, int number, int age)
        {
            PlayerName = name;
            PlayerPosition = position;
            PlayerNumber = number;
            PlayerAge = age;
        }
        public string GetPosition()
        {
            return PlayerPosition;
        }
        public override string ToString()
        {
            return  $"name:\t\t{PlayerName}\n" +
                    $"position:\t{PlayerPosition}\n" +
                    $"number:\t\t{PlayerNumber}\n" +
                    $"age:\t\t{PlayerAge}\n";
        }
    }
    public class Team : IEnumerable
    {
        private List<Player> players;
        public Team()
        {
            players = new List<Player>();
        }
        public void ToAddPlayer(Player player)
        {
            players.Add(player);
        }
        public int Count()
        {
            return players.Count();
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    } 
}
