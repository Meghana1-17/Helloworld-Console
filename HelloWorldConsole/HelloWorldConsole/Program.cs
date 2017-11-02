using HelloWorldConsole.Repo;
using HelloWorldConsole.Service;
using System;
using System.Configuration;
namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomerClient client = new CustomerClient(new CustomerService());
                client.SetCustomreName("Meghana", "Vattikuti");
                string name = client.GetCustomerName();
                
                //read value from configuration file
                string configValue = ConfigurationManager.AppSettings["outputdisplaytext"];
                
                name = string.Format(configValue + " {0}", name);
                Console.Write(name);
            }
            catch (Exception ex)
            {
                Console.Write("Application Error" + ex.Message);
                //TODO: for future expansion, detail exception need to store in seperate output log file with log4net 
            }            
            Console.ReadKey();
        }
    }
}
