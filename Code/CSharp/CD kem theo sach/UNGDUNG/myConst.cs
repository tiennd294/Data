using System;
using System.Collections.Generic;
using System.Text;

namespace UNGDUNG
{
    class myConst
    {
        public const short MDF = 1;
        public const short LDF = 1; 
    }
    public enum ServiceType : short
    {
        Start = 1,
        Stop,
        Pause,
        Continue
    }
}
