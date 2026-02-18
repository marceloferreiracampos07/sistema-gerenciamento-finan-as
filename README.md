# 💰 Gerenciador de Finanças Pessoais em C#

Um sistema de console robusto para controle de entradas e saídas financeiras, desenvolvido com foco em **Programação Orientada a Objetos (POO)** e separação de responsabilidades.

## 🚀 Sobre o Projeto

Este projeto nasceu da necessidade de aplicar conceitos avançados de arquitetura de software, saindo do básico e estruturando uma aplicação que separa a interface do usuário da lógica de negócio e do armazenamento de dados.

## 🏛️ Arquitetura e Design (A Analogia do Chefe e o Funcionário)

Para garantir um código limpo e fácil de manter, o sistema foi dividido em três camadas principais:

1. **Service (O Chefe):** É o cérebro do sistema. Ele detém as **Regras de Negócio**. Antes de qualquer ação, ele valida se os dados estão corretos (ex: se o valor é positivo ou se a descrição é válida). Ele não mexe nas "prateleiras" de dados, ele apenas dá ordens.
2. **Repository (O Funcionário/Almoxarife):** É o responsável pelo estoque (a `List<Transacao>`). Ele executa o **CRUD** (Create, Read, Update, Delete) de forma técnica. Ele não questiona as ordens do Chefe, apenas garante que os dados sejam guardados ou removidos corretamente.
3. **Model (O Produto):** Define a estrutura de uma `Transacao`, com ID automático e tipos específicos (Receita/Despesa).



## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET 8/9)
* **Paradigma:** Orientação a Objetos
* **Versionamento:** Git

## ✨ Funcionalidades

* ✅ Adicionar Receitas e Despesas.
* ✅ Listar Extrato completo com ID único.
* ✅ Cálculo automático de Saldo Total.
* ✅ Filtro de totais por tipo (Entradas/Saídas).
* ✅ Atualizar transações existentes por ID.
* ✅ Remover transações do sistema.

## 📖 Como Executar

1. Clone o repositório:
   ```bash
   git clone [https://github.com/SEU_USUARIO/SistemaGerenciamentoFinancas.git](https://github.com/SEU_USUARIO/SistemaGerenciamentoFinancas.git)
