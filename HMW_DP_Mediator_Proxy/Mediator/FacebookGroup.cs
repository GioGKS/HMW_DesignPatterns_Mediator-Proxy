using System;
using System.Collections.Generic;

namespace HMW_DP_Mediator_Proxy.Mediator
{
    public class FacebookGroup : IFacebookMediator
    {
        private readonly List<Member> members = new List<Member>();
        

        public void AddToGroup(IMember member)
        {
            members.Add((Member)member);
        }

        public void Send(string post, IMember member)
        {
            foreach (IMember mem in members)
            {
                if(mem != member)
                {
                    mem.Recieve(post);
                }
            }
        }

        
    }
}
