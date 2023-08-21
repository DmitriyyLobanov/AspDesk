using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class Controller : IController
    {
        private ILensFileManager lensFileManager;

        public Controller(ILensFileManager lensFileManager)
        {
            this.lensFileManager = lensFileManager;
        }

        public Boolean createNewExistLens(Lens newLens)
        {
            if (lensFileManager.createNewLensFile(newLens))
            {
                return true;
            }
            return false;
        }
    }
}
