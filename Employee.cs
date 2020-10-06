
using System;

namespace ConsoleApp3
{
    interface IEmployeeManager
    {
        bool AddEmployee(Employee ek);
        bool DeleteEmployee(int id);
        bool UpdateEmployee(Employee ek);
        Employee[] ViewEmployee(string Name);
    }

    class EmployeeManager : IEmployeeManager
    {

        private Employee[] allEmployees = null;

        private bool hasEmployee(int id)
        {
            foreach (Employee ek in allEmployees)
            {
                if ((ek != null) && (ek.EmployeeID == id))
                    return true;
            }
            return false;

        }
       
        public EmployeeManager(int size)
        {
            allEmployees = new Employee[size];
        }
        public bool AddEmployee(Employee ek)
        {
            bool available = hasEmployee(ek.EmployeeID);
            if (available)
                throw new Exception("Employee by this ID already exists");
            for (int i = 0; i < allEmployees.Length; i++)
            {
                
                if (allEmployees[i] == null)
                {
                    allEmployees[i] = new Employee();
                    allEmployees[i].EmployeeID = ek.EmployeeID;
                    allEmployees[i].Name = ek.Name;
                    allEmployees[i].Address = ek.Address;
                    allEmployees[i].Salary = ek.Salary;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            for (int i = 0; i < allEmployees.Length; i++)
            {
                
                if ((allEmployees[i] != null) && (allEmployees[i].EmployeeID == id))
                {
                    allEmployees[i] = null;
                    return true;
                }
            }
            return false;
        }

        public Employee[] ViewEmployee(string Name)
        {
           
            Employee[] copy = new Employee[allEmployees.Length];
            
            int index = 0;
            foreach (Employee ek in allEmployees)
            {
               
                if ((ek != null) && (ek.Name.Contains(Name)))
                {
                    copy[index] = ek;
                    index++;
                }
            }

            
            return copy;
        }

        public bool UpdateEmployee(Employee ek)
        {
            for (int i = 0; i < allEmployees.Length; i++)
            {
               
                if ((allEmployees[i] != null) && (allEmployees[i].EmployeeID == ek.EmployeeID))
                {
                    allEmployees[i].Name = ek.Name;
                    allEmployees[i].Address = ek.Address;
                    allEmployees[i].Salary = ek.Salary;
                    return true;
                }
            }
            return false;
        }
    }
    class Employee
    {
        public int EmployeeID
        {
            get; set;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    
    class EmployeeFactoryComponent
    {
        public static IEmployeeManager GetComponent(int size)
        {
            return new EmployeeManager(size);
        }
    }
    class UIClient
    {
        static string menu = string.Empty;
        static IEmployeeManager mgr = null;
        static void InitializeComponent()
        {
            menu = string.Format($"-------------EMPLOYEE MANAGEMENT SYSTEM---------------\nTO ADD A NEW EMPLOYEE------------->PRESS 1\nTO UPDATE A Employee------------>PRESS 2\nTO DELETE A Employee------------PRESS 3\nTO FIND A Employee------------->PRESS 4\nPS:ANY OTHER KEY IS CONSIDERED AS EXIT THE APP\n");
            int size = MyConsole.getNumber("Enter the no of Emplyoees to add");
            mgr = EmployeeFactoryComponent.GetComponent(size);
            mgr.AddEmployee(new Employee { EmployeeID = 123, Name = "Ram", Address = "Mysuru", Salary = 12000 });
            mgr.AddEmployee(new Employee { EmployeeID = 124, Name = "Kumar", Address = "Chennai", Salary = 5000 });
            mgr.AddEmployee(new Employee { EmployeeID = 125, Name = "Raj", Address = "Bengaluru", Salary = 3500 });
            mgr.AddEmployee(new Employee { EmployeeID = 126, Name = "Rajesh", Address = "Hydreabad", Salary = 8000 });

        }

        static void Main(string[] args)
        {
            InitializeComponent();
            bool @continue = true;
            do
            {
                string choice = MyConsole.getString(menu);
                @continue = processing(choice);
            } while (@continue);
        }

        private static bool processing(string choice)
        {
            switch (choice)
            {
                case "1":
                    addingEmployeeFeature();
                    break;
                case "2":
                    updatingEmployeeFeature();
                    break;
                case "3":
                    deletingFeature();
                    break;
                case "4":
                    readingFeature();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void readingFeature()
        {
            string Name = MyConsole.getString("Enter the Name of the employee to search");
            Employee[] Employees = mgr.ViewEmployee(Name);
            foreach (var ek in Employees)
            {
                if (ek != null)
                    Console.WriteLine(ek.Name);
            }
        }

        private static void deletingFeature()
        {
            int id = MyConsole.getNumber("Enter the ID of the Employee to remove");
            if (mgr.DeleteEmployee(id))
                Console.WriteLine("Employee Deleted successfully");
            else
                Console.WriteLine("Could not find the Employee to delete");
        }

        private static void updatingEmployeeFeature()
        {
            Employee ek = new Employee();
            ek.EmployeeID = MyConsole.getNumber("Enter the no of the Employee you wish to update");
            ek.Name = MyConsole.getString("Enter the new Name of the Employee");
            ek.Address = MyConsole.getString("Enter the new Address of the Employee");
            ek.Salary = MyConsole.getDouble("Enter the new Salary of the Employee");
            bool result = mgr.UpdateEmployee(ek);
            if (!result)

                Console.WriteLine($"No Employee by this id {ek.EmployeeID} found to update");
            else
            
            Console.WriteLine($"Employee by ID {ek.EmployeeID} is updated successfully to the database");
        }

        private static void addingEmployeeFeature()
        {
            Employee ek = new Employee();
            ek.EmployeeID = MyConsole.getNumber("Enter the id of the Employee");
            ek.Name = MyConsole.getString("Enter the Name of the Employee");
            ek.Address = MyConsole.getString("Enter the Address of the Employee");
            ek.Salary = MyConsole.getDouble("Enter the Salary of the Employee");
            try
            {
                bool result = mgr.AddEmployee(ek);
                if (!result)
                    Console.WriteLine($"Employee by Name {ek.Name} is added successfully to the database");
            
                else
                    Console.WriteLine("No more Employees could be added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
