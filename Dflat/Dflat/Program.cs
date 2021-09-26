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

            var file = new FileInfo("./Customers.xlsx");         
            var people = GetSetupData(); //Lataa PersonModel listaa sisään

            await SaveExcelFile(people, file);


        }
        private static async Task SaveExcelFile(List<PersonModel> people, FileInfo file)
        {
            DeleteIfExists(file); // Tarkistaa että file on olemassa, jos on, poistaa uuden

            using var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add("MainReport"); // Luo uuden välilehden taulukossa

            var range = ws.Cells["A1"].LoadFromCollection(people, true);
            range.AutoFitColumns();

            await package.SaveAsync();
            
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        private static List<PersonModel> GetSetupData() //Data jota tallennetaan taulukkoon
        {
            List<PersonModel> output = new()
            {
                new() { Id = 1, FirstName = "Joe", LastName = "Doe" },
                new() { Id = 2, FirstName = "Turo", LastName = "Nylund" },
                new() { Id = 3, FirstName = "Veli-Matti", LastName = "Velho" }
            };

            return output;
        } // Helper, Laittaa tietoa outputtiin
    }
}
