using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppTesteConsumoDataExportAPI
{
    public class ListaUltimaPosicaoVeiculosRetorno
    {

        public long idPosicao { get; set; }
        public string frota { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string data { get; set; }
        public int velocidade { get; set; }
        public int satelite { get; set; }
        public string ignicao { get; set; }
        public string direcao { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public long idEquipamento { get; set; }
        public long idVeiculo { get; set; }
        public string bloqueio { get; set; }
        public int odometer { get; set; }
        public int hourmeter { get; set; }

    }

}
