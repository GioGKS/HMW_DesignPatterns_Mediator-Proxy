using System;
namespace HMW_DP_Mediator_Proxy.Mediator
{
    public interface IFacebookMediator
    {
        void Send(string post, IMember member);
        void AddToGroup(IMember member);
    }
}
