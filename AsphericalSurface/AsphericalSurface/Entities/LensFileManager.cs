using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class LensFileManager : ILensFileManager
    {
        public LensFileManager() { }

        // TODO: Проработать исключения
        public bool createNewLensFile(Lens newLens)
        {
            string newFileName = newLens.LensName + ".txt";
            try
            {
                string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string appStorageFolder = Path.Combine(baseFolder, "AsphericalSurface");
                string existLensFolder = Path.Combine(appStorageFolder, "ExistLenses");

                Directory.CreateDirectory(appStorageFolder);
                Directory.CreateDirectory(existLensFolder);

                File.WriteAllText(Path.Combine(existLensFolder + @"\", newFileName), newLens.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return true;
        }


        public bool deleteLensFile(Lens lens)
        {
            string baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string appStorageFolder = Path.Combine(baseFolder, "AsphericalSurface");
            string existLensFolder = Path.Combine(appStorageFolder, "ExistLenses");

            string temp = lens.LensName.Trim();
            byte[] byteLensName = Encoding.Default.GetBytes(temp);

            foreach (string file in Directory.GetFiles(existLensFolder))
            {
                byte[] byteFileName = Encoding.Default.GetBytes(Path.GetFileNameWithoutExtension(file));

                if (BitConverter.ToString(byteLensName) == BitConverter.ToString(byteFileName))
                {
                    File.Delete(file);
                    return true;
                }
            }
            return false;
        }

        public StringBuilder createSurfaceDots(Lens lens)
        {
            StringBuilder dots = dotCalc(lens);

            return dots;
        }


        
        private StringBuilder dotCalc(Lens lens)
        {
            string tempString = "";
            StringBuilder dotsWithNewLineChar = new StringBuilder();
            double y;
            for (double x = -lens.LensWidth / 2; x <= lens.LensWidth / 2; x += 0.001)
            {
                y = Math.Pow(x, 2) / (lens.Radius + Math.Sqrt((Math.Pow(lens.Radius, 2) - (1 + lens.K) * Math.Pow(x, 2)))) + lens.CoefA4 * Math.Pow(x, 4) + lens.CoefA6 * Math.Pow(x, 6) +
                    +lens.CoefA8 * Math.Pow(x, 8) + lens.CoefA10 * Math.Pow(x, 10) + lens.CoefA12 * Math.Pow(x, 12);
                tempString = Math.Round(x, 3).ToString().Replace(',', '.') + " " + (-y).ToString().Replace(',', '.') + Environment.NewLine;
                dotsWithNewLineChar.Append(tempString);
            }
            return dotsWithNewLineChar;
        }
    }

}
