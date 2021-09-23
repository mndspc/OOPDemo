using System;


namespace OOP
{
    //  This class demo. how to override functions from System.Object class.
    class Employee
    {
        public int EmpCode { get; set; }
        public string  EmpName { get; set; }

        public string EmpEmail { get; set; }

    
        public Employee(int empCode, string empName, string empEmail)
        {
            this.EmpCode = empCode;
            this.EmpName = empName;
            this.EmpEmail = empEmail;
        }

        public override string ToString()
        {
            return $"Code={this.EmpCode}\nName={this.EmpName}\nEmail={this.EmpEmail}";
        }

        public override bool Equals(object obj)
        {
            Employee emp =(Employee) obj;
            if(this.EmpCode==emp.EmpCode)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
