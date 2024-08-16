using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesteConsumoDataExportAPI
{
    public class RetornaDadosRequest
    {
        public long idVeiculo { get; set; }
        public long idPosicao { get; set; }
        public long idSensor { get; set; }
        public long idMensagem { get; set; }
        public long idTelemetria { get; set; }
        public long idAlertaVelocidade { get; set; }
        public long idAlertaSensor { get; set; }
        public long idAlertaTemperatura { get; set; }
        public long idCercaAlvo { get; set; }
        public long idCercaCheckPoint { get; set; }
        public long idCercaLogradouro { get; set; }
        public long idCercaPoligonal { get; set; }
        public long idCercaRota { get; set; }

    }
}
