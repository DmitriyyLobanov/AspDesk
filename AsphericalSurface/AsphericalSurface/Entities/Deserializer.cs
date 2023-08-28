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
        public void DeserializeLensFromTXT()
        {
            string userDocsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appStorageFolder = Path.Combine(userDocsFolder, "AsphericalSurface");
            string existLensFolder = Path.Combine(appStorageFolder, "ExistLenses");

            try
            {
                foreach (string file in Directory.GetFiles(existLensFolder))
                {
                    if (File.Exists(file)) 
                    {
                        //string temp;
                        //temp = File.ReadAllText(file);
                        
                        //MessageBox.Show(file);
                        ParseFromTxt(file);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //TODO: Доделать метод парсинга данных из TXT файла
        private void ParseFromTxt(string fullPath)
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
                    MessageBox.Show(parseResult.LensName + " " + parseResult.Radius);
                }
                
            }
        }

    }
}
