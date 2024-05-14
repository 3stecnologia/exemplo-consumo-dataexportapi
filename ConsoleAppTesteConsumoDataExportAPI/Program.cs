using ConsoleAppTesteConsumoDataExportAPI;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

string token = string.Empty;
string dominio = "https://localhost:7210";

Console.WriteLine(DateTime.Now);

try
{

    ValidaLogin validaLogin = new ValidaLogin()
    {
        Usuario = "_Usuario_Disponibilizado_",
        Senha = "_Senha_Disponibilizada_"
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
            UserToken responseLogin = JsonConvert.DeserializeObject<UserToken>(jsonString);

            token = responseLogin.Token;
        }

    }

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

                var responseListaVeiculos = JsonConvert.DeserializeObject<IEnumerable<ListaVeiculos>>(jsonString);

            }

        }

    }

}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(DateTime.Now);
Console.WriteLine("\nConsulta realizada com sucesso!");
Console.WriteLine("\nPressione alguma tecla para encerrar o programa.");

Console.ReadKey();