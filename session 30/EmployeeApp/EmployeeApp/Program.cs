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
            


        }

        private static void CaseStudyForGeneratingEmployingBySalary()
        {
            Console.WriteLine("----------Maximum salary---------------\n");
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
                    $"\tThe highest salary is {maxSalary}");
            }
            
        }

        private static void CaseStudyForGeneratingEmployingById()
        {
            Console.WriteLine("-----------Employees By department id----------------\n");
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
            Console.WriteLine("-----------Employees By designation----------------\n");
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
    }
}
