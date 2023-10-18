using Backend;
using Backend.GBD;

namespace WinFormsApp1
{
    internal static class Program
    {


        static public GestionServeur gestionServeur=new GestionServeur();
        static public GestionBoissons gestionBoisson= new GestionBoissons();
        static public GestionCommande gestionCommande=new GestionCommande();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            Application.Run(new Form1());
        }
    }
}