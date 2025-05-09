

using System.Xml.Linq;



public class Project
{
    public string name { get; set; }
    public Project () { } 
    public Project (string nName)
    {
        name = nName;
    }
}


class Employee
{
    public string name { get; set; }
    public string surname { get; set; }
    public string dept { get; set; }
    public string pos { get; set; }
    public int salary { get; set; }
    public List<Project> currentProjects = new List<Project> ();

    public Employee() { }
    public Employee(
        string nName,
        string nSurname,
        string nDept,
        string nPos,
        int nSalary,
        List<Project>? pList
        )
    {
        name = nName;
        surname = nSurname;
        dept = nDept;
        pos = nPos;
        salary = nSalary;

        if (pList != null)
        {
            currentProjects = pList.ToList ();
        }

       
    }

    public static Employee fish()
    {
        Project Project1 = new Project("Project1");
        Project Project2 = new Project("Project2");

        List<Project> projects = new List<Project>() { Project1, Project2 };

        Employee employee = new Employee(
            "FishFirstName",
            "FishLastName",
            "FishDepartment",
            "FishPosition",
            123457890,
            projects
            );

        return employee;
    }

    public Employee (XElement elm)
    {
        XElement emp = elm.Element("Employee");

        if (emp == null)
        { emp = elm; }

        name = (string)emp.Element("FirstName");
        surname = (string)emp.Element("LastName");
        dept = (string)emp.Element("Department");
        pos = (string)emp.Element("Position");
        salary = (int)emp.Element("Salary");
    }

    public void add_project ( Project p )
    {
        currentProjects.Add ( p );
    }

    public void add_project_batch(List<Project> p)
        { currentProjects.AddRange( p ); }
}

class XMLHandler
{
    XDocument doc;
    string xmlPath;

    public XMLHandler(string path)
    {
        xmlPath = path;
        doc = XDocument.Load (path);
    }

    public List<Employee> get_list()
    {
        var list = doc.Element("Employees")
            .Elements("Employee")
            .ToList();

        List<Employee> empList = new List<Employee>();

        foreach (XElement e in list)
        {
            empList.Add( new Employee(e));
        }

        return empList;
    }

    public List<Employee> get_dept (string deptName)
    {
        List<Employee> empList = get_list()
            .Where(emp => emp.dept == deptName)
            .ToList();
        return empList;
    }

    public List<Employee> get_by_project_count (int count)
    {
        List<Employee> empList = get_list()
            .Where(emp => emp.currentProjects
            .Count() >= count)
            .ToList();
        return empList;
    }

    public Dictionary<int, string> get_id_name()
    {
        var dict = new Dictionary<int, string>();
        var emps = doc.Element("Employees").Elements("Employee");

        foreach (XElement e in emps)
        {
            dict.Add((int)e.Attribute("Id"), (string)e.Element("FirstName"));
        }
        return dict;
    }

    public int get_next_available_id()
    {
        var emps = doc.Element("Employees").Elements("Employee");

        int available_id = 1;

        foreach (XElement e in emps)
        {
            if (available_id == (int)e.Attribute("Id"))
            {
                available_id++;
            }
            else { return available_id; }
        }
        return available_id;
    }

    public void add_employee(Employee emp)
    {
        XElement empElement = new XElement("Employee");
        empElement.Add(new XAttribute("Id", get_next_available_id()));

        empElement.Add(new XElement("FirstName", emp.name));
        empElement.Add(new XElement("LastName", emp.surname));
        empElement.Add(new XElement("Department", emp.dept));
        empElement.Add(new XElement("Position", emp.pos));
        empElement.Add(new XElement("Salary", emp.pos));

        XElement projectsElement = new XElement("Projects");
        foreach (Project prj in emp.currentProjects)
        {
            projectsElement.Add(new XElement("Project", prj.name));
        }



        doc.Element("Employees").Add(empElement);  
        doc.Save(xmlPath);
    }

    public void remove_employee_by_id(int empId)
    {

        //doc.Element("Employees").
        //Elements("Emplyee").
        //Where
        //(
        //    employee =>

        //        employee.
        //        Attribute("Id").
        //        ToString()
        //         == 
        //         "Id=\"" + empId.ToString() + "\""
        //        ).
        //        First().
        //        Remove();
        //doc.Save(xmlPath);


        foreach (XElement emp in doc.Element("Employees").Elements("Employee"))
        {
            //Console.WriteLine(emp.Attribute("Id").ToString());
            //Console.WriteLine("Id=\"" + empId.ToString() + "\"");
            //Console.WriteLine("Id=\"" + empId.ToString() + "\"" == emp.Attribute("Id").ToString());

            if ("Id=\"" + empId.ToString() + "\"" == emp.Attribute("Id").ToString())
            {
                emp.Remove();
            }

        }
        doc.Save(xmlPath);
    }


    public void replace_employee_by_id(int empId, Employee newEmp)
    {
        XElement empElement = new XElement("Employee");
        empElement.Add(new XAttribute("Id", empId));

        empElement.Add(new XElement("FirstName", newEmp.name));
        empElement.Add(new XElement("LastName", newEmp.surname));
        empElement.Add(new XElement("Department", newEmp.dept));
        empElement.Add(new XElement("Position", newEmp.pos));
        empElement.Add(new XElement("Salary", newEmp.pos));


        foreach (XElement emp in doc.Element("Employees").Elements("Employee"))
        {

            if ("Id=\"" + empId.ToString() + "\"" == emp.Attribute("Id").ToString())
            {
                emp.ReplaceWith(empElement);
            }

        }
        doc.Save(xmlPath);
    }

}


namespace EmployeeDataAnalysis
{
    internal class Program
    {
        const string xmlPath = "emp.xml";

        static void Main(string[] args)
        {
            XMLHandler hand = new XMLHandler(xmlPath);

            hand.replace_employee_by_id(15, Employee.fish());
            
        }
    }
}
