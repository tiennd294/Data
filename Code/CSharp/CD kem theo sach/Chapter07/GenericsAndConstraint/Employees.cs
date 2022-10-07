
namespace GenericsAndConstraint
{
    public class Employees
    {
        private string pCode;
        private string pName;
        private string pAddress;
        private int pAge;
        public Employees()
        {

        }
        public Employees(string code, 
        string name, string address, int age)
        {
            pCode = code;
            pName = name;
            pAddress = address;
            pAge  = age;
        }
        public string Code
        {
            get { return pCode ; }
            set { pCode  = value; }
        }
        public string Name
        {
            get { return pName; }
            set { pName = value; }
        }
        public string Address
        {
            get { return pAddress; }
            set { pAddress = value; }
        }
        public int Age
        {
            get { return pAge ; }
            set { pAge  = value; }
        }

    }
}
