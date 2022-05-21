using System;
namespace HMW_DP_Mediator_Proxy.Proxy
{
    public interface IInteriorOffice
    {
        void ChangeCity(string city);
        void UpdateChildrenStatus(int numberofchildren);
        void GetNewID();
        void ChangeFirstName(string newfirstname);
        void ChangeLastName(string newlastname);

    }
}
