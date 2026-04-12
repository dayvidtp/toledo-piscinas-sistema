# 🏊‍♂️ Toledo Piscinas - Management System

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![C#](https://img.shields.io/badge/C%23-Programming-purple)
![Status](https://img.shields.io/badge/status-in%20development-yellow)
![License](https://img.shields.io/badge/license-MIT-green)

A C# console application designed to manage clients and track pool cleaning services.

This project was built to practice **Object-Oriented Programming (OOP)**, **layered architecture**, and **data persistence using JSON**.

---

## 🚀 Features

* ✅ Client registration
* 📋 Client listing
* 🧼 Cleaning service registration
* 📊 Cleaning history tracking
* 💾 Automatic data persistence using JSON

---

## 🧠 Concepts Applied

* Object-Oriented Programming (OOP)
* Layered architecture (UI, Services, Repository, Models)
* JSON data persistence
* Serialization and deserialization
* Separation of concerns
* Code organization best practices

---

## 🏗️ Project Structure

```text id="m9k9g9"
📁 Models
 ├── Cliente.cs
 └── Limpeza.cs

📁 Services
 ├── ClienteService.cs
 ├── LimpezaService.cs
 └── MenuService.cs

📁 Repository
 └── ClienteRepository.cs

📁 UI
 └── ConsoleUI.cs
```

---

## ⚙️ Technologies

* C#
* .NET
* System.Text.Json

---

## 🔄 How It Works

```text id="qql30u"
1 - Register Client
2 - List Clients
3 - Register Cleaning
4 - List Cleanings
0 - Exit
```

* Data is stored in memory during execution
* Clients are automatically saved to `clientes.json`
* Data is loaded when the application starts

---

## 💾 Data Persistence

Using JSON:

* `JsonSerializer.Serialize()` → save data
* `JsonSerializer.Deserialize()` → load data

Generated file:

```text id="xzhicp"
clientes.json
```

---

## 🔮 Future Improvements

* [ ] Persist cleaning records in JSON
* [ ] Add edit and delete features
* [ ] Build an API using ASP.NET
* [ ] Create a graphical interface
* [ ] Improve validations

---

## 👨‍💻 Author

**Dayvid Toledo**

---

## 📌 Notes

This project is part of my learning journey in backend development and software architecture. It will continue to evolve with new features and improvements.




# 🏊‍♂️ Toledo Piscinas - Sistema de Gerenciamento

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![C#](https://img.shields.io/badge/C%23-Programming-purple)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![License](https://img.shields.io/badge/license-MIT-green)

Sistema desenvolvido em C# com foco em gerenciamento de clientes e controle de limpezas de piscinas.

---

## 🚀 Funcionalidades

* ✅ Cadastro de clientes
* 📋 Listagem de clientes
* 🧼 Registro de limpezas
* 📊 Histórico de limpezas
* 💾 Salvamento automático em JSON

---

## 🧠 Conceitos aplicados

* Programação Orientada a Objetos (POO)
* Arquitetura em camadas (UI, Services, Repository, Models)
* Persistência de dados com JSON
* Serialização e desserialização
* Separação de responsabilidades
* Boas práticas de organização de código

---

## 🏗️ Estrutura do Projeto

```text
📁 Models
 ├── Cliente.cs
 └── Limpeza.cs

📁 Services
 ├── ClienteService.cs
 ├── LimpezaService.cs
 └── MenuService.cs

📁 Repository
 └── ClienteRepository.cs

📁 UI
 └── ConsoleUI.cs
```

---

## ⚙️ Tecnologias

* C#
* .NET
* System.Text.Json

---

## 🔄 Funcionamento

```text
1 - Cadastrar Cliente
2 - Listar Clientes
3 - Registrar Limpeza
4 - Listar Limpezas
0 - Sair
```

* Os dados são armazenados em memória durante a execução
* Os clientes são salvos automaticamente em `clientes.json`
* Os dados são carregados ao iniciar o sistema

---

## 💾 Persistência de Dados

Utilizando JSON:

* `JsonSerializer.Serialize()` → salvar dados
* `JsonSerializer.Deserialize()` → carregar dados

Arquivo gerado:

```text
clientes.json
```

---

## 🔮 Melhorias futuras

* [ ] Persistir limpezas em JSON
* [ ] Implementar edição e exclusão
* [ ] Criar API com ASP.NET
* [ ] Interface gráfica
* [ ] Validações mais robustas

---

## 👨‍💻 Autor

**Dayvid Toledo**

---

## 📌 Observação

Projeto desenvolvido com foco em aprendizado prático de desenvolvimento backend e arquitetura de software.
