using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism.Models
{
    public class ProjectManager:Employee
    {

        private double _houseRentAllowence;
        private double _travelRentAllwence;
        private double _dearnessRentAllwent;
        private static string _defaultRole="ProjectManager";

        public ProjectManager(int id, string name, double basicSalary,string role) : base(id, name, basicSalary,role)
        {
            _houseRentAllowence = _basicSalary * 0.5;
            _travelRentAllwence = _basicSalary * 0.4;
            _dearnessRentAllwent = _basicSalary * 0.3;
        }

        public ProjectManager(int id,string name,double basicSalary) : this(id, name, basicSalary, _defaultRole) { 

        }

      

        public override double AnnualCTC()
        {
            return (_houseRentAllowence + _travelRentAllwence + _dearnessRentAllwent+_basicSalary)*12;
        }

        public override void SalaryBreakup()
        {
            Console.WriteLine($"The PersonalAllowence is {_travelRentAllwence}\n" +
                $"The TravelAllowence is {_houseRentAllowence}\n" +
                $"The Dearness allowence is {_dearnessRentAllwent}");

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
                    $"<td>TravelRent allowence</td>" +
                    $"<td>{_travelRentAllwence}</td>" +
                    $"<td>{AnnualCTC()}</td>" +
                    $"</tr>" +
                    $"<tr>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td>House Allowence</td>" +
                    $"<td>{_houseRentAllowence}</td>" +
                    $"</tr>" +
                     $"<tr>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td></td>" +
                    $"<td>DearnessRentAllowce Allowence</td>" +
                    $"<td>{_dearnessRentAllwent}</td>" +
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
