using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_21._10_Pytymko_V.L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("П'еса");
            Piece piece = new Piece("Name Piece1", "Autor Piece1", "Genre Piece1", "Year Piece1");
            piece.Show();
            piece.Dispose();
            piece.Show();
            Console.WriteLine();

            Console.WriteLine("Океанаріум");
            Oceanarium Ocm = new Oceanarium();
            Ocm.AddInhabitants("Shark", "White Shark");
            Ocm.AddInhabitants("Turtle", "NInja Turtle");
            Ocm.AddInhabitants("Dolphin", " 'Love)) ");
            Ocm.AddInhabitants("Fish", "Nemo");
            Ocm.AddInhabitants("Stingray", " Devils of the deep");
            foreach (var creature in Ocm)
            {
                Console.WriteLine($"Name:{creature._Name},Type:{creature._Type} ");

            }
            Console.WriteLine();

            Console.WriteLine(" Футбольна Команда ");
            FC Metallist = new FC();
            Metallist.AddPlayers("Garyainov", "GK", 29);
            Metallist.AddPlayers("PAPA", "CB", 30);
            Metallist.AddPlayers("Obradovich", "CB", 22);
            Metallist.AddPlayers("Azevedo", "LB", 20);
            Metallist.AddPlayers("Villagra", "RB", 3);
            Metallist.AddPlayers("Edmar", "DM", 8);
            Metallist.AddPlayers("Rikun", "CM", 25);
            Metallist.AddPlayers("Xavier", "CM", 10);
            Metallist.AddPlayers("Taison", "LW", 7);
            Metallist.AddPlayers("CocA", "RW", 11);
            Metallist.AddPlayers("Devic", "CF", 33);
            foreach (var player in Metallist)
            {
                Console.WriteLine($"Name:{player._Name} Position:{player._Position} Number:{player._Number}");
            }
            Console.WriteLine();

            Console.WriteLine("Кафе");

            Cafe Friends=new Cafe();
            Friends.Addemployee("GustaFF", "Metrdotel");
            Friends.Addemployee("Jack", "Chef");
            Friends.Addemployee("Lyee", "Cook");
            Friends.Addemployee("Jhon", "Bartender");
            Friends.Addemployee("Helga", "Waiter");
            Friends.Addemployee("Aity", "Waiter");
            Friends.Addemployee("Lybesniy", "Waiter");
            foreach (var emp in Friends) 
            {
                Console.WriteLine($"Name:{emp._Name} Speciality:{emp._Speciality}");
            }


        }
    }
}
