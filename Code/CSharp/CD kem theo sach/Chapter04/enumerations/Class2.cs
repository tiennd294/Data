using System;
namespace enumerations
{
    public enum Login : short
    {
        Logged = 1,
        Logout = 0
    }
    public enum Status : short
    {
        New ,
        Peding,
        Paid,
        Reject
    }
    public enum Other : short
    {
        Administration  ,
        Engineering ,
        Finance ,
        Humanresource ,
        StoreKeepper 
    }	
}
