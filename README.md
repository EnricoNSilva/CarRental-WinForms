# 🚗 Car Rental System - WinForms

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Status](https://img.shields.io/badge/Status-Finalizado%20(v1.0)-brightgreen?style=for-the-badge)

## 📝 Sobre o Projeto

Este é um projeto de aprendizado completo que simula um sistema de gerenciamento para uma locadora de veículos. Desenvolvido em C# com Windows Forms e ADO.NET, o sistema cobre desde o cadastro de entidades até a lógica de negócio de aluguéis e devoluções, culminando em um dashboard com métricas de desempenho.

O projeto foi construído com base em um tutorial, mas foi significativamente refatorado e aprimorado com melhores práticas de design de banco de dados, lógica de negócio robusta e uma arquitetura de código mais segura e eficiente.

## ✨ Funcionalidades Principais

* 🔐 **Sistema de Login:** Autenticação de usuários para acesso ao sistema.
* 📊 **Dashboard com Métricas:** Visualização rápida do status da frota, total de clientes e faturamento.
* 👤 **CRUD Completo de Usuários:** Gerenciamento de operadores do sistema.
* 🧑‍🤝‍🧑 **CRUD Completo de Clientes:** Gerenciamento de clientes com busca por CPF para conformidade com a LGPD.
* 🚙 **CRUD Completo de Carros:** Gerenciamento da frota, utilizando chaves primárias numéricas para melhor desempenho e estabilidade.
* 📑 **Lógica de Aluguel e Devolução:** Transações SQL garantem que o aluguel de um carro e a atualização de sua disponibilidade ocorram de forma atômica e segura.
* 🔄 **Sistema de Devolução Inteligente:** Cálculo automático de atrasos e multas.
* 🔍 **Filtros de Visualização:** Capacidade de alternar entre a visualização de aluguéis ativos e o histórico completo.
* 📄 **Exportação para CSV:** Permite exportar os dados de cada tabela principal para arquivos `.csv`, facilitando a análise em outras ferramentas como o Excel.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET Framework com Windows Forms (WinForms)
* **Acesso a Dados:** ADO.NET
* **Banco de Dados:** Microsoft SQL Server

---
## 🖥️ Explicação das Telas (Forms)

O sistema é dividido em módulos, cada um representado por um formulário com responsabilidades específicas.

### 💧 `Splash.cs` (Tela de Abertura)
* **Função:** É a primeira tela exibida, funcionando como uma tela de carregamento (`loading screen`).
* **Lógica:** Um `Timer` controla uma `ProgressBar` para simular o carregamento do sistema antes de chamar a tela de Login.

### 🔑 `Login.cs` (Tela de Login)
* **Função:** Autenticar o usuário para permitir o acesso ao sistema.
* **Lógica:** O usuário insere `UserName` e `Password`. O sistema consulta a tabela `TB_Users` no banco de dados para verificar se a combinação é válida. Em caso de sucesso, o formulário de Login é ocultado e o Menu Principal (`MainForm`) é exibido.

### 🏠 `MainForm.cs` (Menu Principal)
* **Função:** Servir como o hub de navegação central da aplicação.
* **Lógica:** Contém botões que criam instâncias e exibem os respectivos formulários de gerenciamento (Carros, Clientes, Aluguéis, etc.), escondendo o menu principal para focar na tarefa selecionada. A aplicação retorna ao menu quando uma tela filha é fechada.

### 📈 `Dashboard.cs` (Painel de Controle)
* **Função:** Apresentar uma visão geral e de alto nível sobre o status do negócio.
* **Lógica:** Executa múltiplas queries SQL com funções de agregação (`COUNT`, `SUM`) para buscar dados como:
    * Total de carros na frota.
    * Total de clientes cadastrados.
    * Número de carros atualmente alugados.
    * Número de carros disponíveis.
    * Faturamento total histórico.
    * Utiliza o método `ExecuteScalar` para obter os valores e exibi-los em `Labels`.

### 🚙 `Car.cs` (Gerenciamento de Carros)
* **Função:** Gerenciar o cadastro completo da frota de veículos.
* **Lógica:** Implementa as operações de CRUD (Adicionar, Editar, Deletar) para a tabela `TB_Cars`. A chave primária `CarId` (numérica) é usada para todas as operações, enquanto a placa (`RegNum`) é mantida como um campo de valor único.

### 🧑‍🤝‍🧑 `Customer.cs` (Gerenciamento de Clientes)
* **Função:** Gerenciar o cadastro completo de clientes.
* **Lógica:** Implementa o CRUD para a tabela `TB_Customers`. A busca e a identificação de clientes são feitas pelo `CPF_CNPJ`, que possui uma restrição `UNIQUE` no banco de dados para garantir a integridade dos dados.

### 📑 `rental.cs` (Gerenciamento de Aluguéis)
* **Função:** A tela mais complexa, onde novos aluguéis são registrados e editados.
* **Lógica:**
    * **Seleção de Cliente:** A busca de cliente é feita pelo CPF para proteger os dados. Uma vez encontrado, seu ID e nome são preenchidos na tela.
    * **Seleção de Carro:** O usuário primeiro seleciona um **Modelo** de carro disponível. Isso aciona um evento que preenche uma segunda `ComboBox` com as **Placas** específicas daquele modelo que estão disponíveis.
    * **Registro de Aluguel:** Ao clicar em "Add", uma **Transação SQL** é iniciada para garantir que duas operações ocorram com sucesso:
        1.  Um `INSERT` na tabela `TB_Rent`.
        2.  Um `UPDATE` na tabela `TB_Cars` para marcar o carro como indisponível (`Avaliable = 'No'`).

### ↩️ `Return.cs` (Gerenciamento de Devoluções)
* **Função:** Processar a devolução de um carro alugado.
* **Lógica:**
    * **Seleção de Aluguel:** A tela exibe uma grade com os carros atualmente alugados. O usuário seleciona um para iniciar a devolução.
    * **Cálculo Automático:** Ao selecionar uma data de devolução, o sistema calcula e exibe automaticamente os dias de atraso (comparando com a `ExpectedReturnDate`) e a multa correspondente.
    * **Registro de Devolução:** Ao clicar em "Confirmar Devolução", uma **Transação SQL** é iniciada para:
        1.  Um `INSERT` na tabela `TB_Return` com os dados da devolução.
        2.  Um `UPDATE` na tabela `TB_Cars` para marcar o carro como disponível (`Avaliable = 'Yes'`).
        
### 📄 `Export.cs` (Exportação de Dados)
* **Função:** Fornecer uma interface para o usuário exportar os dados das tabelas principais para arquivos CSV.
* **Lógica:** * Possui um botão para cada tabela principal (Carros, Clientes, etc.).
    * Ao clicar em um botão, o sistema busca todos os dados daquela tabela, monta uma string no formato CSV e utiliza um `SaveFileDialog` para que o usuário escolha onde salvar o arquivo.
    * Utiliza uma classe `CsvHelper` reutilizável para a lógica de formatação, garantindo que campos com caracteres especiais (como vírgulas) sejam tratados corretamente.

---
## 🚀 Como Executar o Projeto

1.  **Pré-requisitos:**
    * Visual Studio 2019 ou superior.
    * .NET Framework 4.7.2 ou superior.
    * Microsoft SQL Server (qualquer edição).

2.  **Banco de Dados:**
    * Execute o script SQL final fornecido no projeto para criar todas as tabelas, chaves e relacionamentos no seu SQL Server.

3.  **String de Conexão:**
    * Abra o projeto no Visual Studio.
    * Em cada arquivo `.cs` que acessa o banco, encontre a string de conexão (ex: `"Data Source=Note-Enrico;..."`) e substitua pelo caminho e credenciais do seu próprio servidor SQL.

4.  **Compilar e Executar:**
    * Pressione `F5` no Visual Studio para compilar e executar a aplicação.

## 🔮 Próximos Passos (Roadmap v2.0)

* [ ] Refatorar o código para uma arquitetura em 3 camadas (UI, BLL, DAL).
* [ ] Implementar um sistema seguro de hashing de senhas com BCrypt.Net.
* [ ] Criar uma tela de relatórios avançados (ex: faturamento por período).

## 👨‍💻 Autor

**Enrico Nascimento Silva**

* **GitHub:** `https://github.com/EnricoNSilva`
* **Email:** `enriconascimento9@gmail.com`