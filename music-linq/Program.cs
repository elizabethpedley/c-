using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            // There is only one artist in this collection from Mount Vernon, what is their name and age?
            var mt = from artist in Artists where artist.Hometown == "Mount Vernon" select new { artist.ArtistName, artist.Age};
            foreach(var artist in mt)
            {
                System.Console.WriteLine(artist);
                System.Console.WriteLine(artist.ArtistName);
                System.Console.WriteLine(artist.Age);

            }
            //Who is the youngest artist in our collection of artists?
            var young = from artist in Artists where artist.Age == Artists.Min(r => r.Age) select artist.ArtistName;
            foreach(var name in young)
            {
                System.Console.WriteLine(name);
            }

            //Display all artists with 'William' somewhere in their real name
            var william = from artist in Artists where artist.RealName.Contains("William") select new {artist.ArtistName, artist.RealName};

            foreach(var artist in william)
            {
                System.Console.WriteLine(artist);
            }
            //Display all groups with names less than 8 characters in length.
            var ladida = from names in Groups where names.GroupName.Length < 8 select names.GroupName;

            foreach(var group in ladida)
            {
                System.Console.WriteLine(group);
            }

            //Display the 3 oldest artist from Atlanta
            var oldies = Artists.OrderBy(a => a.Age).Reverse().Take(3);

            foreach(var old in oldies)
            {
                System.Console.WriteLine(old.Age);
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
