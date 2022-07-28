### Instruções de instalação
Para executar esse projeto é preciso inicialmente clonar o repositório.
Existem duas formas de rodar o projeto:
1) Abrindo Sample.API.sln no Visual Studio e executando o profile Sample.API
2) rodando o comando `dotnet run` na pasta sample-api/Sample.API/
É preciso ter o .NET 6 instalado para executar o projeto.

### Instruções de uso
1) Acesse o Swagger:
(Visual Studio https://localhost:7256/swagger/index.html ou https://localhost:7256/swagger/)
(dotnet run http://localhost:5256/swagger/index.html ou http://localhost:5256/swagger/)
2) Realize o Login:
Insira um e-mail e senha válidos. A lista de usuários cadastrados está em Sample.API.Data.MockDB
("test@mock.com" "123pass", "test2@mock.com" "456pass")
3) Copie o token retornado clique no botão "Authorize" no Swagger. No pop-up, em "Value" adicione `Bearer <TOKEN>` e depois em no botão "Authorize" no pop-up. 
Você está logado, o token expira em 2 horas, ou ao encerrar a aplicação.
4) Agora você pode utilizar os endpoints do Controller Movie. Siga as instruções no Swagger em cada endpoint.

### Escolhas do projeto
Muitas escolhas nesse projeto são simplificadas ao extremo.
O banco de dados dessa aplicação é estático e não é persistente de propósito.
A estrutura de pastas e projetos em um ambiente real seria dividida para não haver acoplamento.
O arquivo .env em um projeto real estaria incluido no .gitignore, nesse exemplo foi mantido para facilitar a execução.