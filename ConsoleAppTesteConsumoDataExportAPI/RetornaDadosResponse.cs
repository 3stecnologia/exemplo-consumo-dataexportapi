using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleAppTesteConsumoDataExportAPI
{

    public class RetornaDadosResponse
    {
        public Dados Dados { get; set; }
    }

    public class Dados
    {
        public List<PosicaoItem> Posicao { get; set; }
        public List<SensorItem> Sensor { get; set; }
        public List<MensagemItem> Mensagem { get; set; }
        public List<TelemetriaItem> Telemetria { get; set; }
        public List<AlertaVelocidadeItem> AlertaVelocidade { get; set; }
        public List<AlertaSensorItem> AlertaSensor { get; set; }
        public List<AlertaTemperaturaItem> AlertaTemperatura { get; set; }
        public List<CercaAlvoItem> CercaAlvo { get; set; }
        public List<CercaCheckPointItem> CercaCheckPoint { get; set; }
        public List<CercaLogradouroItem> CercaLogradouro { get; set; }
        public List<CercaPoligonalItem> CercaPoligonal { get; set; }
        public List<CercaRotaItem> CercaRota { get; set; }
    }

    public class AlertaSensorItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idAlertaSensor { get; set; }
        public DateTime Data { get; set; }
        public string Sensor { get; set; }
        public string Estado { get; set; }
        public long idGateway { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class AlertaTemperaturaItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idAlertaTemperatura { get; set; }
        public DateTime Data { get; set; }
        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
        public string Temp3 { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class AlertaVelocidadeItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idAlerta { get; set; }
        public int VelocidadeLimite { get; set; }
        public DateTime Data { get; set; }
        public int Velocidade { get; set; }
        public long idGateway { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class CercaAlvoItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idCercaAlvo { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Ocorrencia { get; set; }
        public int NivelRisco { get; set; }
        public int Raio { get; set; }
        public DateTime DataInicio { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class CercaCheckPointItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idCercaCheckPoint { get; set; }
        public DateTime Data { get; set; }
        public int HoraChegada { get; set; }
        public int Permanencia { get; set; }
        public string Descricao { get; set; }
        public int Raio { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Ocorrencia { get; set; }
        public int NivelRisco { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class CercaLogradouroItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idCercaLogradouro { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Ocorrencia { get; set; }
        public int NivelRisco { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class CercaPoligonalItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idCercaPoligono { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Ocorrencia { get; set; }
        public int NivelRisco { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class CercaRotaItem
    {
        public long idOcorrenciaAlerta { get; set; }
        public long idCercaRota { get; set; }
        public DateTime Data { get; set; }
        public string Ocorrencia { get; set; }
        public string Descricao { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string OcorrenciaRota { get; set; }
        public int Raio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NivelRisco { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class MensagemItem
    {
        public long idMensagem { get; set; }
        public DateTime Data { get; set; }
        public string Mensagem { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
        public long idCliente { get; set; }
        public long idGrupo { get; set; }
        public string DescricaoMensagem { get; set; }
        public string CamposFormulario { get; set; }
        public long idFormulario { get; set; }
    }

    public class PosicaoItem
    {
        public long idPosicao { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataGPS { get; set; }
        public DateTime DataProcessamento { get; set; }
        public int Velocidade { get; set; }
        public int Satelite { get; set; }
        public string Ignicao { get; set; }
        public int Altitude { get; set; }
        public string Direcao { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
        public string TipoPosicao { get; set; }
        public string TipoTransmissao { get; set; }
        public int Odometro { get; set; }
        public int Horimetro { get; set; }
        public int OrdemPosicao { get; set; }
    }

    public class SensorItem
    {
        public long idEstadoSensor { get; set; }
        public int Sequencia { get; set; }
        public DateTime Data { get; set; }
        public string Sensor { get; set; }
        public string Estado { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

    public class TelemetriaItem
    {
        public long idVeiculoConsolidado { get; set; }
        public long idVeiculo { get; set; }
        public DateTime Data { get; set; }
        public string Motorista { get; set; }
        public string DiaSemana { get; set; }
        public int TempoSinal { get; set; }
        public int TempoSemSinal { get; set; }
        public int TempoExpediente { get; set; }
        public int TempoMovimento { get; set; }
        public int TempoParado { get; set; }
        public int TempoMarchaLenta { get; set; }
        public int TempoEstacionado { get; set; }
        public int TempoPermanenciaPonto { get; set; }
        public string HoraInicioExpediente { get; set; }
        public string HoraFimExpediente { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeMedia { get; set; }
        public int VelocidadeMediaMovimento { get; set; }
        public int AltitudeMinima { get; set; }
        public int AltitudeMaxima { get; set; }
        public int AltitudeMedia { get; set; }
        public int RPMMaxima { get; set; }
        public int RPMMediaMovimento { get; set; }
        public int KMTotal { get; set; }
        public int QtdeAlertasVelocidade { get; set; }
        public int QtdeAbastecimento { get; set; }
        public int QtdeLitros { get; set; }
        public double ValorTotalAbastecimento { get; set; }
        public int HodometroInicialAbastecimento { get; set; }
        public int HodometroFinalAbastecimento { get; set; }
        public int TempoAlertaVelocidade { get; set; }
        public int TempoAlertaVelocidadeChuva { get; set; }
        public int TempoBanguela { get; set; }
        public int VelocidadeMaximaChuva { get; set; }
        public int QtdeAlertasVelocidadeChuva { get; set; }
        public int QtdeBanguela { get; set; }
        public long idEquipamento { get; set; }
        public long NumSerie { get; set; }
    }

}
