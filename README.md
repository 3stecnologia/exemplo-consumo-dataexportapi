# exemplo-consumo-dataexportapi

## Sobre o projeto:

O projeto de exemplo tem por objetivo demonstrar de forma simples e prática como consumir a Web API - DataExportAPI da 3S Tecnologia.

## Como utilizar o projeto:

#### 1. Clone o proejto:
```bash
$ git clone https://github.com/3stecnologia/exemplo-consumo-dataexportapi.git
```
#### 2. Atualize a classe "Program.cs" com as credenciais de acesso previamente disponibilizadas através de nossos canais de relacionamento:
```C#
ValidaLogin validaLogin = new ValidaLogin()
{
    Usuario = "_Usuario_Disponibilizado_",
    Senha = "_Senha_Disponibilizada_"
};
```
#### 3. Compile o projeto:
```bash
$ dotnet build
```
#### 4. Execute o projeto:
```bash
$ dotnet run --project ConsoleAppTesteConsumoDataExportAPI/ConsoleAppTesteConsumoDataExportAPI.csproj
```

