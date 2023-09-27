using AsphericalSurface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class LensStorage : ILensStorage
    {
        private List<Lens> lens;
        IDeserializer deserializer;

        public LensStorage(IDeserializer deserializer)
        {
            this.lens = new List<Lens>();
            this.deserializer = deserializer;
        }


        public void updateList()
        {
            lens.Clear();
            lens = deserializer.DeserializeLensFromTXT();
        }

        public List<Lens> getLens()
        {
            updateList();   
            return lens;
        }
    }

}
