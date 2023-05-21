using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinalConcept
{
    public class ExceptionHandling
    {
        int id;
        string itemName;
        int tax;

        public ExceptionHandling()
        {
            Console.WriteLine("server is connected to database");
        }
        public void DisplayMenuDetails(int id, string itemName, int tax)
        {
            try
            {
                this.id = id;
                this.itemName = itemName;
                this.tax = tax;

                Console.WriteLine(id);
                Console.WriteLine(itemName);
                Console.WriteLine(180 / tax);
            }
            catch
            {
                Console.WriteLine("Hi, i am getting exception");
            }
            finally
            {
                Console.WriteLine("Enjoy your Lunch");
                Console.WriteLine("server is disconnected from database");
            }
           
        }
    }
        }
    

