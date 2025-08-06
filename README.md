# Consumindo-API-em-CSharp

## 📝 Descrição

Este projeto é uma aplicação realizada no terminal em C# que consome uma API de músicas em formato JSON. A aplicação permite ao usuário visualizar, filtrar, organizar os dados das músicas, criação de playlists e exportá-las para um arquivo `.json`.

É uma atividade de como consumir APIs, manipular coleções de dados com LINQ e serializar objetos para JSON em C#.

## ✨ Funcionalidades

O projeto oferece as seguintes funcionalidades diretamente no terminal:

* **Consumo de API:**
    * Baixa e desserializa uma lista de músicas de uma URL externa.
* **Filtros com LINQ**:
    * Exibe todos os gêneros musicais presentes na base de dados.
    * Exibe uma lista de todos os artistas em ordem alfabética.
    * Filtra e exibe artistas com base em um gênero musical.
    * Filtra e exibe todas as músicas de um determinado artista.
    * Exibe todas as músicas lançadas em um ano específico.
    * Filtra e exibe as músicas por uma tonalidade específica (ex: "C#, D, Ab").
* **Criação de Playlists:**
    * Criação de listas de músicas favoritas.
    * Adiciona músicas específicas a uma playlist.
    * Exibe os detalhes das playlists criadas.
* **Exportação para JSON:**
    * Gera um arquivo `.json` contendo as informações de uma playlist, como o nome e a lista de músicas.

## 🚀 Tecnologias Utilizadas

* **C# 12**
* **.NET 8**
* **System.Text.Json:** Para desserializar a resposta da API e serializar as playlists para arquivos JSON.
* **LINQ (Language Integrated Query):** Utilizado para realizar as consultas e filtros de dados das músicas.
* **HttpClient:** Para fazer as requisições HTTP e obter os dados da API.

## ⚙️ Como Executar

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone 
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd 
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

## 📂 Estrutura do Projeto

* **`Program.cs`**: Ponto de entrada da aplicação. Controla o fluxo, consome a API e chama os métodos de filtro.
* **`/model`**: Contém as classes que representam os dados da aplicação.
    * **`Song.cs`**: Define a estrutura de uma música (Artista, Nome, Gênero, etc.).
    * **`FavoriteSongs.cs`**: Classe para gerenciar a criação de playlists de músicas favoritas.
* **`/filter`**: Contém as lógicas de consulta.
    * **`LinqFilter.cs`**: Classe estática com métodos que usam LINQ para filtrar e exibir os dados das músicas.
