using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSYFinalAttempt;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string AdvisorType { get; set; }
    // Employee Information 

    public Employee(int employeeID, string name, string advisorType)
    {
        EmployeeID = employeeID;
        Name = name;
        AdvisorType = advisorType;
    }
    // constructor 

    // Employee employee1 = new Employee(1, "John Doe", "CFA");
    // Employee employee2 = new Employee(2, "Jane Smith", "CFP");
}
