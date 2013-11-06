using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mochila
{
    class objecto
    {
        public float custo { get; set; }
        public float beneficio { get; set; }
        public float ratio { get; set; }

        public objecto(float c, float b)
        {
            this.custo = c;
            this.beneficio = b;
            this.ratio = b / c;
        }
    }
}
