using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities.Interfaces
{
    internal interface ILensStorage
    {
        public void updateList();
        public List<Lens> getLens();
    }

}
