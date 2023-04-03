using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    public class DadosMeteorologicos
    {
        public double TemperaturaAr { get; set; }   
        public double TemperaturaChao { get; set; }
        public double VelocidadeVento { get; set; }
        public DirecaoVento DirecaoVento { get; set; }
        public double Pressao { get; set; }
        public int PrecipitacaoChuva { get; set; }

        public void Coletar()
        {

        }

        public string Resumir(int formato, string cabecalho, string rodape)
        {
            return "";
        }
    }
}
