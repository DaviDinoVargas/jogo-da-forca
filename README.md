# 🪢 Jogo da Forca

## 📌 Introdução  
**O Jogo da Forca** é uma aplicação de linha de comando em **C#** que simula o jogo da forca. O Desafia consiste no jogador adivinhar o nome de um dinossauro, fornecendo tentativas limitadas e exibição gráfica do boneco sendo enforcado. O projeto serve para a utilização de conceitos fundamentais da linguagem, como **loops, estrutura condicional, manipulação de strings e entrada do usuário**.

## 🚀 Funcionalidades  

✅ **Geração Aleatória de Palavras:**  
- O jogo escolhe um nome de dinossauro aleatoriamente para ser adivinhado.

✅ **Exibição Gráfica da Forca:**  
- Imprimi no console o boneco sendo enforcado conforme os erros aumentam.

✅ **Validação de Entrada:**  
- Garante que apenas letras válidas sejam inseridas.

✅ **Controle de Tentativas:**  
- O jogador perde após 6 erros.

✅ **Opção de Jogar Novamente:**  
- Permite reiniciar a partida após vencer ou perder.

---

## 💻 Exemplo de Execução:
![](https://i.imgur.com/gF7hXo3.gif)

## 🛠 Como utilizar:

🚀 Passo a Passo

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do projeto.
3. Utilize o comando abaixo para restaurar as dependências do projeto:

```
dotnet restore
```
4. Em seguida, compile a solução com o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real:
```
dotnet run --project JogoDaForca.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta `./JogoDaForca.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
JogoDaForca.ConsoleApp.exe
```

## ✅ Requisitos  
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

