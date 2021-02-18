# Calculadora Financeira Web Api

Api que calcula juros compostos.


## Instalação

```bash
git clone https://github.com/lucianaregi/CalculadoraFinanceiraWebApi
cd CalculadoraFinanceiraWebApi/src/TaxaJurosAPI
docker-compose up -d
cd CalculadoraFinanceiraWebApi/src/CalculaJurosAPI
docker-compose up -d
```

## Como usar

```swagger
api taxaJuros => swagger: http://localhost:8001
api calculaJuros => swagger: http://localhost:8002

```

## Melhorias
- Melhorar os testes unitários
- Criar log de erros;
- Criar autenticação com token jwt;
- Criar testes de integração;
- Criar testes com cypress;
- Verificar a intermitência do docker no windows 10


## Licença
[MIT](https://choosealicense.com/licenses/mit/)
