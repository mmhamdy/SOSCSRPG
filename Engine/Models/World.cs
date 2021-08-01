using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _Locations = new List<Location>();

        internal void AddLocation(int xcoordinate, int ycoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = xcoordinate;
            loc.YCoordinate = ycoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _Locations.Add(loc);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach(Location loc in _Locations)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
