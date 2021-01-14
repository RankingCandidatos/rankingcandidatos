# Ranking de Candidatos

## Descrição

*Para* cidadãos, *cujo* objetivo para as próximas eleições é avaliar melhor os candidados o *Ranking de Candidatos*, que é uma plataforma web, irá permitir criar o perfil de um cadidato em que o cidadão tenha interesse em dar seu voto, para centralizar e organizar informações que ajudem a avaliar e comparar com outros candidatos, organizando posts, reportagem, videos e quaisquer propostas e opiniões por área como educação, saúde, planejamento. O cidadão poderá pontuar as informações como positivas ou negativas e a plataforma faz um calculo para apresentar quais canditatos tem maior compatibilidade com os interesses do cidadão.

## Tecnologias

+ Angular
	- Bootstrap (validar com galera mais "frontender" da Lambda)
+ .NET Core
+ Azure DevOps (Criar email da "pequena empresa")
+ Azure REAL OFICIAL (Criar email da "pequena empresa")
+ Github (Criar email da "pequena empresa")
+ MongoDB
+ Autenticação Oauth2 Facebook
+ Docker

## Pré-requisitos para desenvolvimento
+ .net 5
+ Docker Desktop

## Antes de executar a aplicação localmente
Para executar a aplicação localmente é necessário e executar o docker-compose.yml, localizado na raiz do projeto, para criar o container do mongodb e mongo-express
```
$ docker-compose up -d
```
Feito isso será possível gerenciar o banco de dados através do browser acessando `http://localhost:8081`

---

## Features

+ Cadastrar um novo candidato - $$$
+ Cadastro de link - $$$

+ Resultado de busca de candidatos por cidade - $$
	+ Filtro por prefeito ou vereador
	+ Ordenar pela pontuação do candidato
	
+ Tela de detalhe do candidato - $$
+ Tela de comparação de candidato - $$

+ Pontuação - $$
+ Inclusão de tags - $$

+ Autenticação - $

## Detalhes das estruturas

+ Candidato
	- Nome
	- Número de candidato
	- Cidade
	- Partido
	- Candidatura
	- Nota arbitrária
	- Redes Sociais
	
+ Link
	- Tópico
	- Descrição
	- Endereço
  
