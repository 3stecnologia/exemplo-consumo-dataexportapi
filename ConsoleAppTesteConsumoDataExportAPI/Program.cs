using ConsoleAppTesteConsumoDataExportAPI;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http.Headers;
using System.Text;


string token = string.Empty;
string dominio = "https://3stecnologia.eti.br/dataexportapi";
long idVeiculo = 0;
DateTime inicioPesquisa;
DateTime fimPesquisa;

try
{

    begin:

    Console.WriteLine($"Menu de Pesquisa DataExportAPI\n");

    Console.WriteLine($"Digite o código:\n");

    Console.WriteLine("1 para a pesquisa \"ListaVeiculos\"");
    Console.WriteLine("2 para a pesquisa \"ListaUltimaPosicaoVeiculos\"");
    Console.WriteLine("3 para a pesquisa \"RetornaDados\"");
    Console.WriteLine("4 para encerrar a pesquisa\n");

    int opcao = Console.Read();

    #region Login

    ValidaLoginRequest validaLogin = new ValidaLoginRequest()
    {
        Usuario = "_Usuario_Disponibilizado_",
        Senha = "_Usuario_Disponibilizado_"
    };

    using (HttpClient client = new HttpClient())
    {

        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

        StringContent content = new StringContent(JsonConvert.SerializeObject(validaLogin), Encoding.UTF8, "application/json");

        string url = $"{dominio}/ValidaLogin";
        var response = await client.PostAsync(url, content);

        if (response != null)
        {
            string jsonString = await response.Content.ReadAsStringAsync();

            if (jsonString.Contains("3S.1038"))
            {
                throw new Exception("3S.1038 - Usuário ou senha inválidos.");
            }

            UserToken userToken = JsonConvert.DeserializeObject<UserToken>(jsonString);

            token = userToken.Token;
        }

    }

    #endregion

    switch (opcao)
    {
        case (int)EnumOpcaoPesquisa.opcaoListaVeiculos:

            #region ListaVeiculos

            Console.WriteLine("\n\"ListaVeiculos\"\n");

            inicioPesquisa = DateTime.Now;

            if (!string.IsNullOrEmpty(token))
            {

                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    string url = $"{dominio}/ListaVeiculos";
                    var response = await client.GetAsync(url);

                    if (response != null)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        var listaVeiculosRetorno = JsonConvert.DeserializeObject<IEnumerable<ListaVeiculosRetorno>>(jsonString);

                        short nohVeiculo = 0;

                        Console.WriteLine($"Frota: {listaVeiculosRetorno.ToList()[nohVeiculo].Frota}");
                        Console.WriteLine($"Veículo/Placa: {listaVeiculosRetorno.ToList()[nohVeiculo].Placa}");
                        Console.WriteLine($"IdVeiculo: {(long)listaVeiculosRetorno.ToList()[nohVeiculo].idVeiculo}");

                    }

                }

            }

            fimPesquisa = DateTime.Now;

            Console.WriteLine($"\n\nPesquisa realizada com sucesso em {fimPesquisa.Subtract(inicioPesquisa).TotalSeconds} segundos!");
            
            #endregion

            break;

        case (int)EnumOpcaoPesquisa.opcaoListaUltimaPosicaoVeiculos:

            #region ListaUltimaPosicaoVeiculos

            Console.WriteLine("\n\"ListaUltimaPosicaoVeiculos\"\n");

            inicioPesquisa = DateTime.Now;

            if (!string.IsNullOrEmpty(token))
            {

                Console.WriteLine($"Informe um IdVeiculo, utilize a pesquisa \"ListaVeiculos\" para ter acesso ao código ou 0 para retornar ao menu.\n");
                Console.ReadLine();

                try
                {
                    idVeiculo = long.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"IdVeiculo inválido, por favor tente novamente!\n");
                    idVeiculo = long.Parse(Console.ReadLine());
                }

                if (idVeiculo == 0)
                {
                    Console.Clear();
                    goto begin;
                }
                else
                {

                    using (HttpClient client = new HttpClient())
                    {

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                        string url = $"{dominio}/ListaUltimaPosicaoVeiculos/{idVeiculo}";
                        var response = await client.GetAsync(url);

                        if (response != null)
                        {
                            string jsonString = await response.Content.ReadAsStringAsync();

                            var listaUltimaPosicaoVeiculosRetorno = JsonConvert.DeserializeObject<IEnumerable<ListaUltimaPosicaoVeiculosRetorno>>(jsonString);

                            Console.WriteLine($"\nLatitude: {listaUltimaPosicaoVeiculosRetorno.ToList()[0].latitude}");
                            Console.WriteLine($"Longitude: {listaUltimaPosicaoVeiculosRetorno.ToList()[0].longitude}");
                        }

                    }

                }

            }

            fimPesquisa = DateTime.Now;

            Console.WriteLine($"\n\nPesquisa realizada com sucesso em {fimPesquisa.Subtract(inicioPesquisa).TotalSeconds} segundos!");

            #endregion

            break;

        case (int)EnumOpcaoPesquisa.opcaoRetornaDados:

            #region RetornaDados

            Console.WriteLine("\n\"RetornaDados\"\n");

            inicioPesquisa = DateTime.Now;

            RetornaDadosRequest retornaDadosRequest = new RetornaDadosRequest()
            {
                idVeiculo = 0,
                idPosicao = 0,
                idSensor = 0,
                idMensagem = 0,
                idTelemetria = 0,
                idAlertaVelocidade = 0,
                idAlertaSensor = 0,
                idAlertaTemperatura = 0,
                idCercaAlvo = 0,
                idCercaCheckPoint = 0,
                idCercaLogradouro = 0,
                idCercaPoligonal = 0,
                idCercaRota = 0
            };

            if (!string.IsNullOrEmpty(token))
            {

                using (HttpClient client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                    StringContent content = new StringContent(JsonConvert.SerializeObject(retornaDadosRequest), Encoding.UTF8, "application/json");

                    string url = $"{dominio}/RetornaDados";
                    var response = await client.PostAsync(url, content);

                    if (response != null)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();

                        var retornaDadosResponse = JsonConvert.DeserializeObject<RetornaDadosResponse>(jsonString);

                        Console.WriteLine($"IdPosicao: {retornaDadosResponse.Dados.Posicao[0].idPosicao}");
                        Console.WriteLine($"Data: {retornaDadosResponse.Dados.Posicao[0].Data}");
                        Console.WriteLine($"DataGPS: {retornaDadosResponse.Dados.Posicao[0].DataGPS}");
                        Console.WriteLine($"DataProcessamento: {retornaDadosResponse.Dados.Posicao[0].DataProcessamento}");
                        Console.WriteLine($"Velocidade: {retornaDadosResponse.Dados.Posicao[0].Velocidade}");
                        Console.WriteLine($"Satelite: {retornaDadosResponse.Dados.Posicao[0].Satelite}");
                        Console.WriteLine($"Ignicao: {retornaDadosResponse.Dados.Posicao[0].Ignicao}");
                        Console.WriteLine($"Altitude: {retornaDadosResponse.Dados.Posicao[0].Altitude}");
                        Console.WriteLine($"Direcao: {retornaDadosResponse.Dados.Posicao[0].Direcao}");
                        Console.WriteLine($"UF: {retornaDadosResponse.Dados.Posicao[0].UF}");
                        Console.WriteLine($"Cidade: {retornaDadosResponse.Dados.Posicao[0].Cidade}");
                        Console.WriteLine($"Bairro: {retornaDadosResponse.Dados.Posicao[0].Bairro}");
                        Console.WriteLine($"Endereco: {retornaDadosResponse.Dados.Posicao[0].Endereco}");
                        Console.WriteLine($"Numero: {retornaDadosResponse.Dados.Posicao[0].Numero}");
                        Console.WriteLine($"CEP: {retornaDadosResponse.Dados.Posicao[0].CEP}");
                        Console.WriteLine($"Latitude: {retornaDadosResponse.Dados.Posicao[0].Latitude}");
                        Console.WriteLine($"Longitude: {retornaDadosResponse.Dados.Posicao[0].Longitude}");
                        Console.WriteLine($"idEquipamento: {retornaDadosResponse.Dados.Posicao[0].idEquipamento}");
                        Console.WriteLine($"NumSerie: {retornaDadosResponse.Dados.Posicao[0].NumSerie}");
                        Console.WriteLine($"TipoPosicao: {retornaDadosResponse.Dados.Posicao[0].TipoPosicao}");
                        Console.WriteLine($"TipoTransmissao: {retornaDadosResponse.Dados.Posicao[0].TipoTransmissao}");
                        Console.WriteLine($"Odometro: {retornaDadosResponse.Dados.Posicao[0].Odometro}");
                        Console.WriteLine($"Horimetro: {retornaDadosResponse.Dados.Posicao[0].Horimetro}");
                        Console.WriteLine($"OrdemPosicao: {retornaDadosResponse.Dados.Posicao[0].OrdemPosicao}");

                    }

                }

            }

            fimPesquisa = DateTime.Now;

            Console.WriteLine($"\n\nPesquisa realizada com sucesso em {fimPesquisa.Subtract(inicioPesquisa).TotalSeconds} segundos!");

            #endregion

            break;

        case (int)EnumOpcaoPesquisa.opcaoFim:

            Console.WriteLine("\nObrigado por ter acessado nosso menu de pesquisa!\n");

            Thread.Sleep(5000);

            Console.Clear();

            return;

            break;

        default:

            Console.WriteLine("\nCódigo da Pesquisa inválido!");

            break;

    }

    Console.WriteLine("\nDeseja executar outra pesquisa? [s/N].\n");
    ConsoleKeyInfo reload = Console.ReadKey();

    if (reload.Key == ConsoleKey.S)
    {
        Console.ReadLine();
        Console.Clear();
        goto begin;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\nObrigado por ter acessado nosso menu de pesquisa!\n");
        Environment.Exit(0);
    }

}
catch (System.Exception ex)
{

    Console.WriteLine(ex.Message);

    Console.WriteLine("\n\nFalha na realização da pesquisa, por favor tente novamente!");

    Thread.Sleep(5000);

    Console.Clear();

}

Console.ReadKey();