using PruebaTecnica.BussinessLayer;
using PruebaTecnica.DataAccesLayer;
using PruebaTecnica.Models;
using PruebaTecnica.PresentationLayer;

namespace PruebaTecnica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var contexto = new PruebaTecnicaContext();
            var data = new Data(contexto);
            var bussiness = new Bussiness(data);
            Application.Run(new ABCC(bussiness));
        }
    }
}