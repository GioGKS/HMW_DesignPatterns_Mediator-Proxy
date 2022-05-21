using System;
namespace HMW_DP_Mediator_Proxy.Proxy
{
    public class MinistryOFInterior : IServiceMachine,IInteriorOffice
    {
        public MinistryOFInterior()
        {
        }

        public void ChangeCity(string city)
        {
            Console.WriteLine($"You Changed City,New City is: {city}");
        }

        public void ChangeFirstName(string newfirstname)
        {
            Console.WriteLine($"Your New First Name Is: {newfirstname}");
        }

        public void ChangeHomeAdress(string newadress)
        {
            Console.WriteLine($"Your New Home Adress Is: {newadress}");
        }

        public void ChangeLastName(string newlastname)
        {
            Console.WriteLine($"Your New Last Name Is: {newlastname}");
        }

        public void GetNewID()
        {
            Console.WriteLine("Your ID Will Be Ready In Few Days & Will come With Delivery...");
        }

        public void GetNewPasport()
        {
            Console.WriteLine("Your Pasport Will Be Ready In Few Days & Will come With Delivery...");
        }

        public void UpdateChildrenStatus(int numberofchildren)
        {
            Console.WriteLine($"You Updated Children Status, Now You Have: {numberofchildren} Children!");
        }
    }
}
