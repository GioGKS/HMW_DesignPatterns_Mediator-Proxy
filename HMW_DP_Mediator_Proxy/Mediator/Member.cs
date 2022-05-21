using System;
namespace HMW_DP_Mediator_Proxy.Mediator
{
    public class Member : IMember
    {
        private readonly IFacebookMediator mediator;
        private string name;

        public Member(string name, IFacebookMediator mediator)
        {
            this.name = name;
            this.mediator = mediator;
        }

        public void Publish(string post)
        {
            Console.WriteLine($"{name} Published: {post}");
            mediator.Send(post, this);
        }

        public void Recieve(string post)
        {
            Console.WriteLine($"{name} Recieved Post: {post} ");
            
        }
    }
}
