using System;
using System.Collections ;
using System.ServiceProcess;

namespace UNGDUNG
{
    class myArray
    {
        public ArrayList GetMyServices()
        {
            ArrayList arr = new ArrayList();
            clsItem cls;
            foreach (ServiceController sv in ServiceController.GetServices())
            {
                cls = new clsItem();
                 
                cls.name = sv.ServiceName;
                cls.displayname = sv.DisplayName;
                cls.status = sv.Status.ToString();
                arr.Add(cls);
            }
            return arr;
        }
    }
}
