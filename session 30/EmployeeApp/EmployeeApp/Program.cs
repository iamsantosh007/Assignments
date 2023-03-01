namespace EmployeeApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CaseStudyForGeneratingUniqueRecord();
            CaseStudyForGeneratingEmployingByDesignation();
            CaseStudyForGeneratingEmployingById();
            CaseStudyForGeneratingEmployingBySalary();
           CaseStudyForGeneratingEmployingByIdAndDesignation();
            


        }

        private static void CaseStudyForGeneratingEmployingByIdAndDesignation()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("--------------------Employee With Same Designation And Same DeptId-------------------\n");
            Console.ResetColor();
          Dictionary<string,int> employeeOfDesignationAndJob= GetEmployeeByDepartmentIdAndDesignation();
            foreach(var employee in employeeOfDesignationAndJob)
            {
                string[] designationAndDepId=employee.Key.Split('-');
                if (employee.Value > 1)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine($"The Employee count of same ${designationAndDepId[0]} and ${designationAndDepId[1]} is {employee.Value}\n");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine($"The Employee count of same ${designationAndDepId[0]} and ${designationAndDepId[1]} is {employee.Value}\n");
            }
        }

        private static Dictionary<string,int> GetEmployeeByDepartmentIdAndDesignation()
        {
            Dictionary<string, int> employeeOfDesignationAndId = new Dictionary<string, int>();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile2.txt", FileMode.OpenOrCreate))
            {
                StreamReader reader = new StreamReader(stream);
                string dataLine = reader.ReadLine();

                while (dataLine != null)
                {
                    string[] dataLineArray = dataLine.Split(",");
                    if (!employeeOfDesignationAndId.ContainsKey(dataLineArray[2] + "-" + dataLineArray[7]))
                    {
                        employeeOfDesignationAndId.Add(dataLineArray[2] +"-"+ dataLineArray[7],0);
                    }
                    employeeOfDesignationAndId[dataLineArray[2] + "-" + dataLineArray[7]]++;
                    dataLine = reader.ReadLine();

                    

                }
            }
            return employeeOfDesignationAndId;
        }

        private static void CaseStudyForGeneratingUniqueRecord()
        {
            HashSet<string> uniqueRecord = CaseStudyOne();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile2.txt", FileMode.OpenOrCreate))
            {
                StreamWriter writer = new StreamWriter(stream);
                foreach (string uniqueData in uniqueRecord)
                {
                    writer.WriteLine(uniqueData);
                }
                writer.Close();
            }
        }

        private static HashSet<string> CaseStudyOne()
        {
            HashSet<string> list = new HashSet<string>();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile.txt", FileMode.OpenOrCreate))
            {

                StreamReader reader = new StreamReader(stream);
                //StreamWriter writer=new StreamWriter(stream);

                string dataLine = reader.ReadLine();
                while (dataLine != null)
                {
                    list.Add(dataLine);
                    dataLine = reader.ReadLine();
                }



            }
            return list;
        }
        private static void CaseStudyForGeneratingEmployingBySalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------Maximum salary---------------\n");
            Console.ResetColor();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile2.txt", FileMode.Open))
            {
                StreamReader reader= new StreamReader(stream);
                string dataLine = reader.ReadLine();
                int maxSalary = 0;
                string maxSalaryPersonDetails = null;
                while(dataLine != null)
                {
                    string[] dataLineArray= dataLine.Split(",");
                    int curruntSalary = int.Parse(dataLineArray[dataLineArray.Length - 3]);
                    if ( curruntSalary> maxSalary)
                    {
                        maxSalary= curruntSalary;
                        maxSalaryPersonDetails = dataLine;
                    }
                    dataLine = reader.ReadLine();

                }
                 Console.WriteLine($"{maxSalaryPersonDetails}\n\n" +
                    $"\tThe highest salary is {maxSalary}\n\n");
            }
            
        }

        private static void CaseStudyForGeneratingEmployingById()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------Employees By department id----------------\n");
            Console.ResetColor();
            Dictionary<int, int> employeeById = GetEmployeeByDepartmentId();
            foreach (var employee in employeeById)
            {
                Console.WriteLine($"The Department Id is {employee.Key} and Having {employee.Value} different members");
            }
            Console.WriteLine("\n\n");
        }

        private static Dictionary<int, int> GetEmployeeByDepartmentId()
        {
            Dictionary<int, int> employeeByDesignationSet = new Dictionary<int, int>();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile2.txt", FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);
                string dataLine = reader.ReadLine();

                while (dataLine != null)
                {
                    string[] dataLineArray = dataLine.Split(",");
                    int indexValue = int.Parse(dataLineArray[dataLineArray.Length - 1]);
                    if (!employeeByDesignationSet.ContainsKey(indexValue))
                    {
                        employeeByDesignationSet.Add(indexValue, 0);
                    }

                    foreach (string dataInindex in dataLineArray)
                    {
                        try
                        {

                            int dataIndexValue = int.Parse(dataInindex);
                            if (employeeByDesignationSet.ContainsKey(dataIndexValue))
                            {
                                employeeByDesignationSet[dataIndexValue]++;
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }
                    }

                    dataLine = reader.ReadLine();
                }
            }
            return employeeByDesignationSet;
        }

        private static void CaseStudyForGeneratingEmployingByDesignation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------Employees By designation----------------\n");
            Console.ResetColor();
            Dictionary<string, int> employeeDesignation = GetEmployeeByDesignation();
            foreach (var employee in employeeDesignation)
            {
                Console.WriteLine($"The Designation is {employee.Key} and Having {employee.Value} different members");
            }
            Console.WriteLine("\n\n");
        }



        private static Dictionary<string, int> GetEmployeeByDesignation()
        {
            Dictionary<string, int> employeeByDesignationSet = new Dictionary<string, int>();
            using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 30\\DataFile2.txt", FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);
                string dataLine = reader.ReadLine();

                while (dataLine != null)
                {
                    string[] dataLineArray = dataLine.Split(",");
                    if (!employeeByDesignationSet.ContainsKey(dataLineArray[2]))
                    {
                        employeeByDesignationSet.Add(dataLineArray[2], 0);
                    }
                    foreach (string dataInindex in dataLineArray)
                    {

                        if (employeeByDesignationSet.ContainsKey(dataInindex))
                        {
                            employeeByDesignationSet[dataInindex]++;
                        }
                    }
                    dataLine = reader.ReadLine();
                }
            }
            return employeeByDesignationSet;

        }
    }
}
