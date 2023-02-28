using System.Text.RegularExpressions;

namespace Assignment
{
    [Flags]
    enum securityPrivilage : byte
    {
        Guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8

    }




    enum Gender : byte
    {
        Male = 1,
        Female = 2
    }





    struct Employee : IComparable
    {

        #region Attributes
        int id;
        string name;
        double salary;
        Gender gender;
        securityPrivilage securityLevel;
        HireDate hireDate;
        #endregion






        #region constructor
        public Employee(int _id, string _name, double _salary, Gender _gender, securityPrivilage _secrityLevel, HireDate _hireDate)
        {
            id = _id;
            name = _name;
            salary = _salary;
            gender = _gender;
            securityLevel = _secrityLevel;
            hireDate = _hireDate;

        }
        #endregion







        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public securityPrivilage SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }


        public HireDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


        #endregion











        #region Methods
        public override string ToString()
        {
            return
                $"id = {id}\nName = {name}\nSalary = {salary:c}\nGender = {gender}\n" +
                $"Security Level = {securityLevel}\nHiring Date = {hireDate}";
        }


        public static Employee[] GetEmpArr(int size)
        {
            return new Employee[size];
        }


        public static void FillData(Employee[] EmpArr)
        {
            for (int i = 0; i < EmpArr?.Length; i++)
            {
                Console.WriteLine("Enter data of employee number " + (i + 1));
                do
                {
                    Console.WriteLine("Enter the id:");
                } while (!int.TryParse(Console.ReadLine(), out EmpArr[i].id));


                do
                {
                    Console.WriteLine("Enter the employee name");
                    EmpArr[i].name = Console.ReadLine();
                } while (!Regex.IsMatch(EmpArr[i].name, @"^[a-zA-z]+$"));


                do
                {
                    Console.WriteLine("Enter employee gender ( 1 for male, 2 for female)");
                    EmpArr[i].gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
                } while (!Enum.IsDefined(typeof(Gender), EmpArr[i].gender));


                do
                {
                    Console.WriteLine("Enter employee salary");
                } while (!double.TryParse(Console.ReadLine(), out EmpArr[i].salary));

                bool flag;
                int sp;
                do
                {
                    Console.WriteLine("Enter the security level number (from 1 to 15)");
                    flag = int.TryParse(Console.ReadLine(), out sp);
                } while (! (flag && (sp > 15 || sp < 0)));
                EmpArr[i].securityLevel = (securityPrivilage)sp;


                int day;
                do
                {
                    Console.WriteLine("Enter hire day of employee");
                } while (!(int.TryParse(Console.ReadLine(), out day) && (day >= 1 || day < 31)));
                EmpArr[i].hireDate.Day = day;


                int month;
                do
                {
                    Console.WriteLine("Enter hire month of employee");
                } while (!(int.TryParse(Console.ReadLine(), out month) && (month >= 1 || month < 12)));
                EmpArr[i].hireDate.Month = month;


                int year;
                do
                {
                    Console.WriteLine("Enter hire year of employee");
                } while (!(int.TryParse(Console.ReadLine(), out year) && (year >= 1999 || year < 2022)));
                EmpArr[i].hireDate.Year = year;


            }
        }


        public static void printArr(Employee[] EmpArr)
        {
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine("Employee number" + (i + 1));
                Console.WriteLine(EmpArr[i]);
            }
        }

        public static void sortArrOfEmp(Employee[] EmpArr)
        {
            Array.Sort(EmpArr);
        }

        public int CompareTo(object obj)
        {
            Employee Right = (Employee)obj;
            if (hireDate.Year > Right.hireDate.Year)
                return 1;

            else if (hireDate.Year < Right.hireDate.Year)
                return -1;

            else
            {
                if (hireDate.Month > Right.hireDate.Month)
                    return 1;


                else if (hireDate.Month < Right.hireDate.Month)
                    return -1;

                else
                {
                    if (hireDate.Day > Right.hireDate.Day)
                        return 1;

                    else if (hireDate.Day < Right.hireDate.Day)
                        return -1;

                    else
                        return 0;
                }
            }
        }
        #endregion








    }
}
