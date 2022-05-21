using System;
namespace HMW_DP_Mediator_Proxy.Proxy
{
    public class PersonProxy : IServiceMachine
    {
        public PersonProxy()
        {
        }

        public void ChangeHomeAdress(string newadress)
        {
            Console.WriteLine($"Your New Home Adress Is: {newadress}");
        }

        public void GetNewPasport()
        {
            Console.WriteLine("Your Pasport Will Be Ready In Few Days & Will come With Delivery...");
        }
    }
}
