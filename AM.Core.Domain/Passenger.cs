using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }

        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber:{PassportNumber}, EmailAddress:{EmailAddress}," +
                $"FirstName: {FirstName},LastName: {LastName},TelNumber:{TelNumber},";
        }

       // public bool CheckProfile(string FName,string LName, string email) {
         //   if(FName== this.FirstName && LName==this.LastName && email==this.EmailAddress) return true; 
           // return false;
             //   }

        public bool CheckProfile(string FName, string LName)
        {
            if (FName == this.FirstName && LName == this.LastName) return true;
            return false;
        }

        public bool CheckProfile(string FName, string LName,string email)
        {
            if (FName == this.FirstName && LName == this.LastName)
            {
                if (email == null || email == this.EmailAddress)
                {
                    return true;
                }
            }
            return false;
        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }

        public void GetAge(DateTime birthDate,ref  int calculatedAge) {

            calculatedAge = (int)(DateTime.Now - birthDate).TotalDays;

        }
        public void GetAge(Passenger aPassenger) {
        aPassenger.Age = ((int)(DateTime.Now - aPassenger.BirthDate).TotalDays)/365;


        }
    }
}
