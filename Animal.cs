using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {

        private String _nome;

        public  String Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        private String _tipo;

        public String Tipo
        {
            get { return _tipo; }
            
            set {

                if (value == "Cachorro" || value == "Gato" || value == "Peixe") 
                {
                    _tipo = value;

                }
                   

                else 
                {
                    _tipo = "Peixe";
                
                }

            }
        }





    }
}
