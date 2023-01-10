using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreConsoleInteractorCS
{
    public class DatabaseView
    {
        DatabaseController controller;
        
        public void Process()
        {
            Console.WriteLine("Input connection string >> ");
            string connection_string = Console.ReadLine();
            controller = new DatabaseController(connection_string);
            while (true)
            {
                int action = controller.ShowActionList();
                controller.Execute(action);
            }
        }
    }
}
