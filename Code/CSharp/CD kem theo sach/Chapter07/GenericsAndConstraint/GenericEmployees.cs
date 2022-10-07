using System;
using System.Collections.Generic;

namespace GenericsAndConstraint
{
    public class GenericEmployees<T> 
    where T : Employees
    {        
        private EmployeeNode Info;

        public GenericEmployees() 
        {
            Info = null;
        }

        public void AddInfo(T t)
        {
            EmployeeNode n = new EmployeeNode(t);
            n.NextNode = Info;
            Info = n;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            EmployeeNode current = Info;

            while (current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            }
        }

        public T FindEmployee(string strName)
        {
            EmployeeNode current = Info;
            T t = null;

            while (current != null)
            {               
                if (current.Data.Name == strName)
                {
                    t = current.Data;
                    break;
                }
                else
                {
                    current = current.NextNode;
                }
            }
            return t;
        }

        private class EmployeeNode
        {
            private EmployeeNode next;
            private T data;

            public EmployeeNode(T t)
            {
                next = null;
                data = t;
            }

            public EmployeeNode NextNode
            {
                get { return next; }
                set { next = value; }
            }

            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
    }
}
