# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me


# Desafio de projeto 🏨
Este desafio foi desenvolvido como parte do módulo de exploração da linguagem C# do bootcamp .Net Developer.

## Contexto
Foi construído um sistema de hospedagem para realizar reservas em um hotel. Foram utilizadas as classes Pessoa, que representa o hóspede, Suíte e Reserva, que estabelece o relacionamento entre ambos.

O programa calcula corretamente os valores dos métodos da classe Reserva, incluindo a quantidade de hóspedes e o valor da diária, com um desconto de 10% para reservas com duração superior a 10 dias.

## Regras e validações
Não é possível realizar uma reserva em uma suíte com capacidade menor que a quantidade de hóspedes. Se a suíte tem capacidade para 2 pessoas e forem informados 3 hóspedes, uma exceção será lançada.

O método ObterQuantidadeHospedes da classe Reserva retorna o número total de hóspedes, enquanto o método CalcularValorDiaria retorna o valor da diária (dias reservados multiplicados pelo valor da diária).

Reservas iguais ou superiores a 10 dias recebem um desconto de 10% no valor da diária.

## Solução
As classes foram implementadas conforme as regras e validações definidas. O código inicial estava pela metade, mas foi possível dar continuidade e garantir um programa funcional com as orientações do professor.