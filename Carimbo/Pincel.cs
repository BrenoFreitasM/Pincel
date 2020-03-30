using System;
using System.Collections.Generic;
using System.Text;

namespace ProgCarimbo
{
    class Pincel : Interacao
    {
        /*carga, cor, texto, diametroDaPonta, Tampa */
        private int carga;
        private string cor;
        private string texto;

        //*+ construtor(texto)
        public Pincel(string Ptexto)
        {
           trocarTexto(Ptexto);
        }

        //- metodos GET SET
        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        //    M E T O D O S
        
            public void usar()
        {
            if(carga >= 1)
            {
                if (!String.IsNullOrEmpty(Texto))
                {
                    if (!String.IsNullOrEmpty(Cor))
                    {
                        Console.WriteLine("(" + Texto + ") na cor " + Cor);
                        carga--;
                    }
                    else
                    {
                        Console.WriteLine("Impossível Escrever - pincel sem cor");
                    }
                }
                else
                {
                    Console.WriteLine("Impossível Escrever - Pincel sem texto");
                }
            }
            else
            {
                Console.WriteLine("Impossível Escrever - Pincel tampado!");
            }
        }
          //+ destampar()
          public void destampar(string Pcor, int Pcarga)
        {
            trocaCor(Pcor);
            if((Pcarga < 1 && Pcarga > 10) && ((Carga + Pcarga) > 10)){
                Console.WriteLine("Carga atual: " + Carga + ", A carga deve ser entre 1 e 10");
            }
            else
            {
                Carga = Pcarga;
            }
        }
         
            //+ tampar()
          
            
          
          public void trocaCor(string PCor)
        {
            if(PCor == Cor)
            {
                Console.WriteLine("Pincel já esta com esta cor!");
            }
            else
            {
                Cor = PCor;
            }
        }
       
        
          public void trocarTexto(string Ptexto)
        {
            if(Ptexto == Texto)
            {
                Console.WriteLine("Pincel já esta com este texto!");
            }
            else
            {
                Texto = Ptexto;
            }
        }
          
    }
}
