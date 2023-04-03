using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data()
        {
            Dia = 0;
            Mes = 0;
            Ano = 0;
        }

        public Data(int dia, int mes, int ano)
        {
            if ((dia >= 1) && (dia <= 31))
            {
                Dia = dia;
            }
            else
            {
                Dia = 1;
            }


            if ((mes >= 1) && (mes <= 12))
            {
                Mes = mes;
            }
            else
            {
                Mes = 1;
            }


            if (ano >= 1)
            {
                Ano = ano;
            }
            else
            {
                Ano = DateTime.Now.Year;
            }
        }

        public string FormatarData()
        {
            return $"{Dia.ToString()}/{Mes.ToString()}/{Ano.ToString()}";
        }

        public string NomeMes()
        {
            switch (Mes)
            {
                case 1:
                    return "Janeiro";
                 case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    return "";
            }
        }

    }
}
