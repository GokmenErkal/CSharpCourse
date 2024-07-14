using System;

namespace Interfaces2
{
    public class Program
    {
        // interface'ler new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager cm = new CustomerManager();
            //IPersonManager em = new EmployeeManager();

            //cm.Add();
            //cm.Update();

            //em.Add();
            //em.Update();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    // inherits - class ----------------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Employee Güncellendi.");
        }
    }

    class InternManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Intern Güncellendi.");
        }
    }

    class  ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
