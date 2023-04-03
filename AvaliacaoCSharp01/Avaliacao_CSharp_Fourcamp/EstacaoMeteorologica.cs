using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    public class EstacaoMeteorologica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool EmOperacao  { get; set; }

        public String RelatarStatus()
        {
            return "";
        }

        public void RelatarClima()
        {

        }

        public void EconomizarEnergia(bool economizar)
        {

        }

        public void ControlarRemoto(bool controleRemoto)
        {

        }

        public bool Reconfigurar(int parametro, string valor, bool reiniciar)
        {
            return true;
        }

        public int Reiniciar(int delay, bool interromperProcessos)
        {
            return 1;
        }
    }
}
