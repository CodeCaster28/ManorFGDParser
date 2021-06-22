using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGDManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
            GameDefinitionLoader fgdLoader = new GameDefinitionLoader();
            
            var command = "";
            while (command != "exit")
            {
                Console.WriteLine("==============================================================");
                Console.WriteLine("Available commands:");
                Console.WriteLine(" parse - parse and print results");
                Console.WriteLine(" create - create MD's from FGD and Specs");
                Console.WriteLine(" generatejsons - generate empty specs jsons for every entity");
                Console.WriteLine(" exit - close program");
                Console.WriteLine("==============================================================");
                command = Console.ReadLine();

                switch (command)
                {
                    case "parse":
                        fgdLoader.Parse();
                        break;
                    case "create":
                        fgdLoader.GenerateOutput();
                        break;
                    case "generatejsons":
                        fgdLoader.GenerateJsons();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Command not found");
                        break;
                }
            }
        }
    }
}