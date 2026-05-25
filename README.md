# 🔐 Gerador de Senha

Aplicação de console em C# que gera senhas aleatórias com comprimento definido pelo usuário.

## 📋 Funcionalidades

- Geração de senhas aleatórias com comprimento personalizado
- Conjunto de caracteres amplo: letras maiúsculas, minúsculas, números e símbolos especiais
- Interface interativa via terminal com fluxo de repetição
- Validação de entrada com tratamento de erros

## 🧰 Tecnologias

- **Linguagem:** C#
- **Plataforma:** .NET (qualquer versão compatível com `System` e `Console`)

## 🚀 Como executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado

### Passos

```bash
# Clone ou copie o arquivo Gerador_Senha.cs para uma pasta
# Compile o projeto
dotnet run
```

Ou, se preferir compilar manualmente:

```bash
csc Gerador_Senha.cs
mono Gerador_Senha.exe  # Linux/macOS
Gerador_Senha.exe       # Windows
```

## 🖥️ Como usar

1. Ao iniciar, o programa pergunta se você deseja gerar uma senha (`s` ou `n`)
2. Se `s`, informe o comprimento desejado para a senha
3. A senha gerada será exibida no terminal
4. Você pode optar por gerar outra senha ou encerrar o programa

### Exemplo de uso

```
Gostaria de gerar uma senha? (s/n)
s
Gerador de Senha
Digite o comprimento da senha:
16
Senha gerada: aB3$kLmZ!9qRwT#2

Deseja gerar outra senha? (s/n)
n
Saindo do programa. Até mais!
```

## 🔣 Caracteres utilizados

| Tipo               | Exemplos                        |
|--------------------|---------------------------------|
| Letras maiúsculas  | A–Z                             |
| Letras minúsculas  | a–z                             |
| Números            | 0–9                             |
| Símbolos especiais | `! @ # $ % ^ & * ( )`          |

## ⚠️ Observações

- Entradas não numéricas para o comprimento da senha são tratadas com uma mensagem de erro, sem encerrar o programa
- Respostas inválidas nas perguntas de confirmação encerram o programa automaticamente
- A cada nova sessão, a tela é limpa para melhor legibilidade
