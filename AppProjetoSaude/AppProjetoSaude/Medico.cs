using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProjetoSaude
{
    public class Medico
    {

        public int codigoM;
        public string nomeM;
        public string celularM;
        public string enderecoM;
        public int numeroM;
        public string bairroM;
        public string cidadeM;
        public string cepM;
        public string estadoM;
        public string statusM;

        public void AlteraStatus()
        {

            this.statusM = "I";
        }

    }
}
