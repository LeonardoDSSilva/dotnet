# .NET

## .NET CLI
### Comandos Básicos
- `dotnet` - Exibir a lista de comandos disponíveis e informações sobre a CLI do .NET.
- `dotnet --version` - Verificar a versão do SDK do .NET instalada. Isso é útil para garantir que você esteja usando a versão correta do SDK para o seu projeto.
- `dotnet help` - Obter ajuda sobre os comandos do .NET CLI. Isso fornece uma lista de todos os comandos disponíveis e suas descrições.
- `dotnet new console -n MyApp` - Criar um novo projeto de console .NET com o nome MyApp.
- `dotnet build` - Compilar o projeto atual. Isso gera os arquivos de saída necessários para executar o aplicativo.
- `dotnet run` - Executar o aplicativo. Isso compila e executa o projeto atual em um único comando.
- `dotnet test` - Executar os testes do projeto atual. Isso compila o projeto e executa os testes definidos.
- `dotnet add package <package_name>` - Adicionar um pacote NuGet ao projeto atual. Isso permite que você use bibliotecas de terceiros em seu aplicativo.
- `dotnet restore` - Restaurar as dependências do projeto. Isso baixa e instala os pacotes NuGet necessários para o projeto.
- `dotnet clean` - Limpar os arquivos de saída do projeto. Isso remove os arquivos gerados pela compilação anterior.
- `dotnet watch` - Monitorar alterações no código e recompilar automaticamente. Isso é útil durante o desenvolvimento, pois permite que você veja as alterações em tempo real sem precisar compilar manualmente.
- `dotnet sln` - Gerenciar soluções do .NET. Isso permite adicionar ou remover projetos de uma solução existente.
- `dotnet ef` - Usar o Entity Framework Core CLI. Isso permite que você execute comandos relacionados ao Entity Framework, como criar migrações e atualizar o banco de dados.
- `dotnet user-secrets` - Gerenciar segredos de usuário para aplicativos .NET. Isso é útil para armazenar informações sensíveis, como senhas e chaves de API, durante o desenvolvimento.
- `dotnet tool` - Gerenciar ferramentas do .NET CLI. Isso permite instalar, atualizar e remover ferramentas adicionais que podem ser usadas com o .NET CLI.
- `dotnet workload` - Gerenciar cargas de trabalho do .NET. Isso permite instalar e remover cargas de trabalho específicas, como ASP.NET ou desenvolvimento móvel.

### MIGRAÇÕES
- `dotnet ef migrations add <migration_name>` - Criar uma nova migração com o nome especificado. Isso gera um arquivo de migração que contém as alterações no modelo de dados.
- `dotnet ef migrations remove` - Remover a última migração criada. Isso é útil se você cometeu um erro na migração ou deseja desfazer as alterações.
- `dotnet ef migrations list` - Listar todas as migrações aplicadas ao banco de dados. Isso fornece uma visão geral das alterações feitas no modelo de dados.
- `dotnet ef database update` - Aplicar as migrações pendentes ao banco de dados. Isso atualiza o banco de dados para refletir as alterações no modelo de dados.

<!-- - `dotnet publish` - Publicar o aplicativo para distribuição. Isso cria uma versão otimizada do aplicativo que pode ser implantada em um servidor ou distribuída para usuários finais.
- `dotnet migrate` - Migrar um projeto para uma versão mais recente do .NET. Isso é útil quando você está atualizando um projeto existente para uma nova versão do SDK.
- `dotnet format` - Formatar o código-fonte do projeto. Isso aplica regras de formatação de código para garantir que o código siga um estilo consistente.
- `dotnet pack` - Criar um pacote NuGet a partir do projeto. Isso é útil para distribuir bibliotecas e componentes reutilizáveis.
- `dotnet publish -c Release` - Publicar o aplicativo em modo de liberação. Isso cria uma versão otimizada do aplicativo para produção.
- `dotnet test --filter "Category=Unit"` - Executar apenas os testes que pertencem à categoria "Unit". Isso é útil para filtrar quais testes você deseja executar com base em atributos personalizados.
- `dotnet watch test` - Monitorar alterações nos testes e executá-los automaticamente. Isso é útil para garantir que os testes sejam executados sempre que você fizer alterações no código.
- `dotnet new sln -n MySolution` - Criar uma nova solução do .NET com o nome MySolution. Isso é útil para organizar vários projetos em uma única solução. -->
