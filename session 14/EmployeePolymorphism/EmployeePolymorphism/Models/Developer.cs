using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Models
{
    public class Developer:Employee
    {
        private double _personalAllowence;
        private double _travelRentAllwence;
        private static string _defaultRole = "Developer";
       

        public Developer(int id,string name,double basicSalary):this(id,name,basicSalary,_defaultRole)
        {

           
        }

        public Developer(int id ,string name,double basicSalary,string role):base(id,name,basicSalary,role)
        {
            _personalAllowence = _basicSalary * 0.4;
            _travelRentAllwence = _basicSalary * 0.3;
        }

        public override double AnnualCTC()
        {
            return (_travelRentAllwence + _personalAllowence + _basicSalary)*12;
        }

        public override void SalaryBreakup()
        {
            Console.WriteLine($"The PersonalAllowence is {_personalAllowence}\n" +
                $"The TravelAllowence is {_travelRentAllwence}");
            
            using (FileStream stream = new FileStream($"E:\\Swabhav Assignments\\session 14\\Developer_{Name}.html", FileMode.OpenOrCreate))
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
                    $"<td>TravelRent allowence</td>" +
                    $"<td>{_travelRentAllwence}</td>" +
                    $"<td>{AnnualCTC()}</td>" +
                    $"</tr>" +
                    $"<tr>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td>Personal Allowence</td>" +
                    $"<td>{_personalAllowence}</td>" +
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
