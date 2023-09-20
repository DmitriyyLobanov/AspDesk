using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class Controller : IController
    {
        private ILensFileManager lensFileManager;

        public Controller()
        {
            this.lensFileManager = new LensFileManager();
        }

        public Boolean createNewLens(Lens newLens)
        {
            if (lensFileManager.createNewLensFile(newLens))
            {
                return true;
            }
            return false;
        }


        public bool deleteLens(Lens lens)
        {
            if (lensFileManager.deleteLensFile(lens))
            {
                return true;
            }
            return false;
        }

    }

}
