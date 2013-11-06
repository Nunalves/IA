using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mochila
{
    class objecto
    {
        public float custo { get; set; } // no caso da mochila será o peso do objecto a inserir
        public float beneficio { get; set; } // no caso da mochila é o valor do objecto a inserir
        public float ratio { get; set; } // relação entre o valor e o peso, quanto maior melhor

        public objecto(float c, float b)
        {
            this.custo = c;
            this.beneficio = b;
            this.ratio = b / c;
        }
    }
}
