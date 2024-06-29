# Banking App
![Tamanho do repositório do GitHub](https://img.shields.io/github/repo-size/luis-domingues/banking-app?style=flat)
![Contagem de linguagens do GitHub](https://img.shields.io/github/languages/count/luis-domingues/banking-app?style=flat)
![Forks do GitHub](https://img.shields.io/github/forks/luis-domingues/banking-app?style=flat)

<video controls src="./assets/video/video.mp4" title="Demo"></video>

> Este projeto está em desenvolvimento ⚠️

## Sobre o aplicativo 📁
Este é um dos meus pequenos projetos nos quais pretendo criar um aplicativo que simula um aplicativo bancário usando meus conhecimentos em C#, como Programação Orientada a Objetos (OOP), Interfaces, entre outros fundamentos.
O programa AINDA não está completo, mas certamente irei melhorá-lo e finalizá-lo.

## Atualizações 🆙
- [x] Atributo 'Balance' alterado para `public` para permitir acesso no método ShowBalance.

- [x] Inicialização do saldo da conta no construtor da classe 'ClientAccount'.

- [x] Ajuste no método ShowBalance para exibir o valor atual do saldo da conta.

- [x] Implementação do método WithdrawMoney para realizar saques da conta, com validação de saldo e tratamento de erros.

- [x] Implementação do tratamento de exceção `FormatException` para entradas inválidas no menu principal.

- [ ] Implementação do método Deposit para permitir depósitos na conta, com validação e tratamento de erros.

- [ ] Implementação do método Transfer para realizar transações para outras contas.

## Uso 🔧
### Pré-requisitos

1. Você precisa ter o [.NET](https://dotnet.microsoft.com/pt-br/) instalado, juntamente com a versão do SDK ou Runtime.

2. Versão do .NET: 6.0 ou superior.

3. Com o .NET instalado em sua máquina, execute o seguinte comando para instalar o [NLog](https://www.nuget.org/packages/NLog):

```
dotnet add package NLog --version 5.3.2
```

Para usar o banking-app, clone este repositório:
```bash
git clone https://github.com/luis-domingues/banking-app
```

Em seguida, nicie o projeto com:
```
dotnet run
```

## Colaboradores ✍
<img src="https://avatars.githubusercontent.com/u/157630664?v=4" width="100px;"/><br /><sub><b>Luís Paulo Domingues</b></sub>

## Contribuição 🤝
Contribuições são sempre bem-vindas! Abra um problema ou envie uma solicitação pull para o repositório.

<h3>Documentações que podem ajudar</h3>

[📝 How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)