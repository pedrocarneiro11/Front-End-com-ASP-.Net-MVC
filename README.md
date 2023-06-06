<h1 align="center">Front End com ASP .NET MVC 👋</h1>
<p>
</p>

 Uma pagina de listagem e criacao de contatos que sao armazenados em um banco de dados, por intermedio de uma API feita em .NET.

 Essa API fornece endpoints para interagir com os contatos, podendo criar, editar, ler e apagar contatos.

# Endpoints:

### GET
Exibe a página inicial
<br>http://localhost:5263/

Exibe a página de política de privacidade 
<br>http://localhost:5263/Home/Privacy

Retorna a página de exibição de contatos
<br>http://localhost:5263/Contato

### GET
Exibe a página de criação de um novo contato:
<br>http://localhost:5263/Contato/Criar

### GET
Método GET para exibir detalhes de um contato já cadastrado

http://localhost:5263/Contato/Detalhes/"Id"

OBS.: Aonde está escrito "Id", digitar a id do contato a ser exibido, SEM aspas

### POST
Criação de um novo contato: 
<br>http://localhost:5263/Contato/Criar

Exemplo:
<br>http://localhost:5263/Contato/Criar?Nome="NomeTeste"&Telefone=999999999&Ativo=True

Parâmetros da query

| Nome  | Telefone | Ativo |
|-------|----------|-------|
|"NomeTeste"|999999999|True|

### POST
Método Post para alterar um contato já cadastrado
<br>http://localhost:5263/Contato/Editar/1?Nome=NomeTesteAlterado&Telefone=888888888&Ativo=False

Parâmetros da query
| Nome  | Telefone | Ativo |
|-------|----------|-------|
|NomeTesteAlterado|888888888|False|

### POST
Método POST para deletar um contato.
<br>http://localhost:5263/Contato/Deletar/"Id"

OBS.: Aonde está escrito "Id", digitar a id do contato a ser deletado, SEM aspas