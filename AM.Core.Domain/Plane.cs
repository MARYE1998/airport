using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boeing = 1,
        Airbus = 2
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return $"Capacity:{Capacity}, ManufuctureDate: {ManufactureDate},MyPlaneType: {MyPlaneType} ";
        }
        public Plane()
        {
        }

        public Plane(PlaneType myPlaneType, int capacity, DateTime manufactureDate)
        {
            MyPlaneType = myPlaneType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }
    }
}
