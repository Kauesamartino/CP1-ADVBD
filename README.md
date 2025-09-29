Kauê Vinicius Samartino da Silva - RM559317

Lucas Borges de Souza - RM560027

Davi Praxedes Santos Silva - RM560719

Bruno Carlos Soares - RM559250

João dos Santos Cardoso de Jesus - RM560400

Pedro Henrique da Silva - RM560393


## 📋 Descrição
Este é um projeto desenvolvido como parte do Checkpoint 1 (CP1) da disciplina de Advanced Business Development with .NET da FIAP. O programa em C# verifica se uma pessoa pode obter carteira de motorista com base na idade e status de emancipação.

## 🎯 Funcionalidades
- Solicita o nome do usuário
- Calcula a idade com base na data de nascimento
- Verifica se a pessoa pode tirar carteira de motorista seguindo as regras:
  - **Menor de 16 anos**: Não pode tirar carteira
  - **Entre 16 e 18 anos**: Pode tirar apenas se for emancipado(a)
  - **18 anos ou mais**: Pode tirar carteira normalmente

## 🛠️ Tecnologias Utilizadas
- C# (.NET 8.0)
- Console Application

## 📁 Estrutura do Projeto
```
CP1-ADVBD/
├── Cp1Q2.sln
├── Cp1Q2/
│   ├── Cp1Q2.csproj
│   ├── Program.cs
└── README.md
```

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 SDK instalado
- Visual Studio ou VS Code (opcional)

### Execução
1. Clone o repositório:
```bash
git clone https://github.com/Kauesamartino/CP1-ADVBD.git
cd CP1-ADVBD
```

2. Navegue até o diretório do projeto:
```bash
cd Cp1Q2
```

3. Execute o programa:
```bash
dotnet run
```

### Exemplo de Uso
```
Insira aqui o seu nome: João
Insira aqui o dia de seu nascimento (dd/mm/yyyy): 15/03/2005
Voce tem 20 Anos
João, Voce pode tirar carteira, bem vindo de volta, Max Verstappen!
```

## 📝 Regras de Negócio
O programa implementa as seguintes regras para carteira de motorista:

1. **Idade < 16 anos**: Não permitido
2. **Idade entre 16-17 anos**: Permitido apenas se emancipado
3. **Idade ≥ 18 anos**: Permitido

## 🎓 Instituição
**FIAP** - Faculdade de Informática e Administração Paulista  
**Curso**: Tecnologia  
**Disciplina**: Advanced Database (ADVBD)  
**Semestre**: 2º Semestre

## 📄 Licença
Este projeto foi desenvolvido para fins educacionais como parte das atividades acadêmicas da FIAP.

---
*Desenvolvido em Setembro de 2025*