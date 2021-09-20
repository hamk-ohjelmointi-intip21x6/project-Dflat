using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using OfficeOpenXml;


namespace Dflat
{
    class Program
    {
        static async Task Main(string[] args) // async mahdollistaa ei-synkroonisten metodien kutsua Main metodin sisälle
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var file = new FileInfo(@"..\Data\Customers.xlsx");         
            var people = GetSetupData(); //Lataa PersonModel listaa sisään

            await SaveExcelFile(people, file);


        }


        private static Task SaveExcelFile(List<PersonModel> people, FileInfo file)
        {
            DeleteIfExists(file); // Tarkistaa että file on olemassa, jos on, poistaa uuden

            using (var package = new ExcelPackage(file)) 
            {

                package.Dispose(); // Varmistaa että kun ohjelma sulkeutuu, tiedosto on taas käytössä (puhdistaa)
            }
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        private static List<PersonModel> GetSetupData()
        {
            List<PersonModel> output = new()
            {
                new() { Id = 1, FirstName = "Joe", LastName = "Doe" },
                new() { Id = 1, FirstName = "Turo", LastName = "Nylund" },
                new() { Id = 1, FirstName = "Veli-Matti", LastName = "Velho" },
            };

            return output;
        } // Helper, Laittaa tietoa outputtiin
    }
}
