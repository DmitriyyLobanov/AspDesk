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


        public Lens calculateMacroLens(Lens scalableLens, double scaleCoef)
        {
            Lens newMacroLens = new Lens
            {
                LensName = scalableLens.LensName.TrimStart() + $"_Macro_x{scaleCoef}",
                LensThinckness = scalableLens.LensThinckness * scaleCoef,
                LensWidth = scalableLens.LensWidth * scaleCoef,
                Radius = scalableLens.Radius * scaleCoef
            };
            if (scalableLens.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                newMacroLens.Surface = SURFACE_TYPES.ASPHERICAL;
                newMacroLens.K = scalableLens.K;
                newMacroLens.CoefA4 = scalableLens.CoefA4/Math.Pow(scaleCoef, 3);
                newMacroLens.CoefA6 = scalableLens.CoefA6 / Math.Pow(scaleCoef, 5);
                newMacroLens.CoefA8 = scalableLens.CoefA8 / Math.Pow(scaleCoef, 7);
                newMacroLens.CoefA10 = scalableLens.CoefA10 / Math.Pow(scaleCoef, 9);
                newMacroLens.CoefA12 = scalableLens.CoefA12 / Math.Pow(scaleCoef, 11);
            }


            return newMacroLens;
        }

        public StringBuilder createDotsFile(Lens lens)
        {
            return lensFileManager.createSurfaceDots(lens);
        }
    }

}
