using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities.Interfaces
{
    internal interface IController
    {
        public Boolean createNewLens(Lens newLens);

        public Boolean deleteLens(Lens lens);

        public Lens calculateMacroLens(Lens scalableLens, double scaleCoef);
        public StringBuilder createDotsFile(Lens lens);
    }

}
