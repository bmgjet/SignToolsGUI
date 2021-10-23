using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignToolsGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WriteResourceToFile("SignToolsGUI.System.Buffers.dll", "System.Buffers.dll");
            WriteResourceToFile("SignToolsGUI.UnityEngine.CoreModule.dll", "UnityEngine.CoreModule.dll");
            WriteResourceToFile("SignToolsGUI.UnityEngine.SharedInternalsModule.dll", "UnityEngine.SharedInternalsModule.dl");
            WriteResourceToFile("SignToolsGUI.LZ4pn.dll", "LZ4pn.dll");
            WriteResourceToFile("SignToolsGUI.LZ4.dll", "LZ4.dll");
            WriteResourceToFile("SignToolsGUI.Facepunch.System.exe", "Facepunch.System.exe");
            WriteResourceToFile("SignToolsGUI.Rust.Data.dll", "Rust.Data.dll");
            WriteResourceToFile("SignToolsGUI.Rust.World.dll", "Rust.World.dll");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
        public static void WriteResourceToFile(string resourceName, string fileName)
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }
    }
}
