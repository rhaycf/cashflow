## Sobre o projeto

Esta API foi desenvolvida com **.NET 8** e utiliza os princípios do **Domain-Driven Design (DDD)** para organizar as responsabilidades e as regras de negócio da aplicação. O objetivo do projeto é permitir o gerenciamento de despesas pessoais, com informações como título, data e hora, descrição, valor e tipo de pagamento, armazenadas em um banco de dados **MySQL**.

A API segue o padrão **REST**, disponibilizando endpoints para as operações da aplicação. Para facilitar a exploração e os testes das funcionalidades, o projeto conta com documentação interativa por meio do **Swagger**.

Dentre os pacotes NuGet utilizados, o **AutoMapper** facilita o mapeamento entre objetos da aplicação, reduzindo a necessidade de código repetitivo. O **FluentValidation** é utilizado para definir regras de validação nas requisições, contribuindo para um código mais organizado e de fácil manutenção. Para o acesso ao banco de dados, o **Entity Framework Core**, integrado ao **MySQL** por meio do provedor **Pomelo**, permite manipular os dados utilizando objetos .NET, simplificando as operações de persistência.

O projeto também utiliza o **ClosedXML** para a geração e manipulação de arquivos Excel e o **PDFsharp-MigraDoc** para a criação de documentos PDF. Nos testes automatizados, o **xUnit** é responsável pela execução dos testes, enquanto o **Shouldly** torna as verificações mais legíveis. O **Bogus** auxilia na geração de dados fictícios para os testes, e o **Coverlet** permite coletar informações sobre a cobertura do código testado.

