﻿using AsphericalSurface.Entities.Interfaces;
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

    }
}
