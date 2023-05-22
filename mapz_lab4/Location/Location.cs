using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace mapz_lab4.Location
{
    public class Location
    {
        public string name { get; set; }
        public int size { get; set; }
        public List<string> availableFishes { get; set; }

        public Location(string name, int size, List<string> availableFishes)
        {
            this.name = name;
            this.size = size;
            this.availableFishes = availableFishes;
        }
        public override string ToString()
        {
            string str = "Name of location : " + name + " . Size of location : " + size + " . Available fishes : ";
            foreach (var fish in availableFishes)
            {
                str += fish + " ";
            }
            str += ".";
            return str;
        }

    }
    public class LocationBuilder
    {
        public string name;
        public int size;
        public List<string> availableFishes;
        public LocationBuilder()
        {
            availableFishes = new List<string>();
        }
        public LocationBuilder setname(string name)
        {
            this.name = name;
            return this;
        }
        public LocationBuilder setsize(int size)
        {
            this.size = size;
            return this;
        }
        public LocationBuilder addAvailableFishes(string fish)
        {
            availableFishes.Add(fish);
            return this;
        }
        public Location buildLocation()
        {
            return new Location(name, size, availableFishes);
        }
    }
    static class LocationCreator
    {
        public static List<Location> LocationsList = new List<Location>();
        static LocationCreator()
        {
            addLake1();
            addLake2();
            addLake3();
            addLake4();
        }
        private static void addLake1()
        {
            LocationBuilder builder = new LocationBuilder();
            builder.setname("Hrushiv")
                .setsize(20)
                .addAvailableFishes("J");
            LocationsList.Add(builder.buildLocation());
        }
        private static void addLake2()
        {
            LocationBuilder builder = new LocationBuilder();
            builder.setname("Svityaz")
                .setsize(40)
                .addAvailableFishes("J")
                .addAvailableFishes("Q");
            LocationsList.Add(builder.buildLocation());
        }
        private static void addLake3()
        {
            LocationBuilder builder = new LocationBuilder();
            builder.setname("Black see")
                .setsize(60)
                .addAvailableFishes("J")
                .addAvailableFishes("Q")
                .addAvailableFishes("K");
            LocationsList.Add(builder.buildLocation());
        }
        private static void addLake4()
        {
            LocationBuilder builder = new LocationBuilder();
            builder.setname("Atlantic ocean")
                .setsize(80)
                .addAvailableFishes("J")
                .addAvailableFishes("Q")
                .addAvailableFishes("K")
                .addAvailableFishes("A");
            LocationsList.Add(builder.buildLocation());
        }
    }
}
