using System;
using System.Collections.Generic;
using System.Text;

namespace ProgCarimbo
{
    interface Interacao
    {
        void usar(); //era carimbar
      //  void tampar(string Pcor, int Pcarga);
        void destampar(string Pcor, int Pcarga);
        void trocaCor(string Pcor);
        void trocarTexto(string Ptexto);
    }
}
