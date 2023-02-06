using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Models
{
    public class QaTester:Employee
    {
        private double _overTimeAllowence;
        private static string _defaultRole = "Tester";
        


        public QaTester(int id, string name, double basicSalary,string role) : base(id, name, basicSalary,role)
        {

            _overTimeAllowence = _basicSalary * 0.3;
        }
        public QaTester(int id,string name,double basicSalary):this(id,name,basicSalary,_defaultRole)
        {

        }
       

        public override double AnnualCTC()
        {
            return (_overTimeAllowence + _basicSalary)*12;
        }

        public override void SalaryBreakup()
        {
            Console.WriteLine($"The OverTimeAllowence is {_overTimeAllowence}");

            using (FileStream stream = new FileStream($"E:\\Swabhav Assignments\\session 14\\ProjectManager_{Name}.html", FileMode.OpenOrCreate))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine($"<html>" +
                    $"<head>" +
                    $"<title></title>" +
                    $"<body>" +
                    $"<table border=1>" +
                    $"<tr>" +
                    $"<th>ID</th>" +
                    $"<th>Name</th>" +
                    $"<th>Basix salary</th>" +
                    $"<th>Allowence</th>" +
                    $"<th>Amount</th>" +
                    $"<th>AnnualCTC</th>" +
                    $"</tr>" +
                    $"<tr>" +
                    $"<td>{Id}</td>" +
                    $"<td>{Name}</td>" +
                    $"<td>{_basicSalary}</td>" +
                    $"<td>OverTimeAllowence</td>" +
                    $"<td>{_overTimeAllowence}</td>" +
                    $"<td>{AnnualCTC()}</td>" +
                    $"</tr>" +
                   
                    $"</table>" +
                    $"</body>" +
                    $"</head>" +
                    $"</html");
                writer.Close();

            }
        }

    }
}
