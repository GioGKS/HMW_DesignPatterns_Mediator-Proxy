using System;
namespace HMW_DP_Mediator_Proxy.Mediator
{
    public interface IMember
    {
        void Publish(string post);
        void Recieve(string post);
    }
}
