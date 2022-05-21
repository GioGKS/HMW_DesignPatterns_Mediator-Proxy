using System;
using HMW_DP_Mediator_Proxy.Mediator;
using HMW_DP_Mediator_Proxy.Proxy;

namespace HMW_DP_Mediator_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mediator Excercise
            Console.WriteLine("* * * * * * * * * * * * * MEDIATOR * * * * * * * * * * * * *\n");
            FacebookGroup closedGroup = new FacebookGroup();
            Member member1 = new Member("Gio", closedGroup);
            Member member2 = new Member("Nick", closedGroup);
            Member member3 = new Member("Michael", closedGroup);
            Member member4 = new Member("Anastasia", closedGroup);

            closedGroup.AddToGroup(member1);
            closedGroup.AddToGroup(member2);
            closedGroup.AddToGroup(member3);
            closedGroup.AddToGroup(member4);

            member1.Publish("Hello,I am New Into This Group,Nice To Meet You!!");
            Console.WriteLine();
            member4.Publish("Hii,My Name Is Anastasia.");
            Console.WriteLine("\n");
            

            //Proxy Excersice
            Console.WriteLine("* * * * * * * * * * * * * PROXY * * * * * * * * * * * * *");
            Console.WriteLine("_____________ ONLY MACHINE FUNCTIONS _____________\n");
            var adam = new PersonProxy();
            adam.ChangeHomeAdress("Rotschild 120");
            adam.GetNewPasport();

            Console.WriteLine("\n_____________ ALL FUNCTIONS _____________\n");
            var ministry = new MinistryOFInterior();
            ministry.ChangeCity("Tel Aviv");
            ministry.ChangeFirstName("George");
            ministry.ChangeLastName("Zats");
            ministry.GetNewID();
            ministry.GetNewPasport();
            ministry.UpdateChildrenStatus(5);
            ministry.ChangeHomeAdress("Balfour 10");

        }
    }
}
