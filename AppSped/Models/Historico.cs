using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSped.Models
{
    public class Historico
    {
        public string CodPaciente { get; set; }
        public DateTime? DataConsulta { get; set; }
        public string Atributo { get; set; }
        public string Observacao { get; set; }
        public string CodMedico { get; set; }
        public string Hist { get; set; }

        public Historico()
        {
            Zerar();
        }

        public Historico(string codPaciente, DateTime dataConsulta, string atributo, string observacao, string codMedico, string hist)
        {
            CodPaciente = codPaciente;
            DataConsulta = dataConsulta;
            Atributo = atributo;
            Observacao = observacao;
            CodMedico = codMedico;
            Hist = hist;
        }

        public void Zerar()
        {
            CodPaciente = "";
            DataConsulta = null;
            Atributo = "";
            Observacao = "";
            CodMedico = "";
            Hist = "";
        }
    }
}
