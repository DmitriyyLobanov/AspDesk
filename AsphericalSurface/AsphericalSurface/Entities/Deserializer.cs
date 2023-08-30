using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class Deserializer : IDeserializer
    {
        public Deserializer()
        {
        }

        //TODO: Реализовать десеарелизацию из файла с параметрами в объект линзы (взять путь у Environment) 
        //TODO: Проработать исключения для десериализатора
        public List<Lens> DeserializeLensFromTXT()
        {
            string userDocsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appStorageFolder = Path.Combine(userDocsFolder, "AsphericalSurface");
            string existLensFolder = Path.Combine(appStorageFolder, "ExistLenses");

            List<Lens> parseLenses = new List<Lens>();

            try
            {
                foreach (string file in Directory.GetFiles(existLensFolder))
                {
                    if (File.Exists(file)) 
                    {
                        Lens currentParseLens = ParseFromTxt(file);
                        parseLenses.Add(currentParseLens);
                    }
                }
                return parseLenses;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //TODO: Доделать метод парсинга данных из TXT файла, сделать изящнее, куча if это отстой
        private Lens ParseFromTxt(string fullPath)
        {
            Lens parseResult = new Lens();
            foreach (var line in File.ReadAllLines(fullPath))
            {
                string currentLine = line;
                if (currentLine.Contains("Имя продукта: "))
                {
                    string temp = currentLine.Remove(0, 13);
                    parseResult.LensName = temp;
                }
                if (currentLine.Equals("Тип поверхности: ASPHERICAL"))
                {
                    parseResult.Surface = SURFACE_TYPES.ASPHERICAL;
                }
                if (currentLine.Equals("Тип поверхности: SPHERICAL"))
                {
                    parseResult.Surface = SURFACE_TYPES.SPHERICAL;
                }
                if (currentLine.Contains("Толщина линзы: "))
                {
                    string temp = currentLine.Remove(0, 14);
                    parseResult.LensThinckness = Double.Parse(temp);
                }
                if (currentLine.Contains("Ширина линзы: "))
                {
                    string temp = currentLine.Remove(0, 13);
                    parseResult.LensWidth = Double.Parse(temp);
                }
                if (currentLine.Contains("Радиус: "))
                {
                    string temp = currentLine.Remove(0, 7);
                    parseResult.Radius = Double.Parse(temp);
                }
                if (currentLine.Contains("Коническая постоянная: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 22);
                    parseResult.K = Double.Parse(temp);
                }
                if (currentLine.Contains("A4: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 3);
                    parseResult.CoefA4 = Double.Parse(temp);
                }
                if (currentLine.Contains("A6: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 3);
                    parseResult.CoefA6 = Double.Parse(temp);
                }
                if (currentLine.Contains("A8: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 3);
                    parseResult.CoefA8 = Double.Parse(temp);
                }
                if (currentLine.Contains("A10: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 4);
                    parseResult.CoefA10 = Double.Parse(temp);
                }
                if (currentLine.Contains("A12: ") && parseResult.Surface == SURFACE_TYPES.ASPHERICAL)
                {
                    string temp = currentLine.Remove(0, 4);
                    parseResult.CoefA12 = Double.Parse(temp);
                }
            }
            return parseResult;
        }

    }
}
