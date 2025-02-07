﻿using System;
using CalculadoraApp;

class Program
{
    static void Main(string[] args)
      {
       Console.WriteLine("Bem-vindo à Calculadora!");
        Calculadora calculadora = new Calculadora();

        double num1 = calculadora.LerNumero("Digite o primeiro número: ");
        double num2 = calculadora.LerNumero("Digite o segundo número: ");

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1. Adição (+)");
        Console.WriteLine("2. Subtração (-)");
        Console.WriteLine("3. Multiplicação (*)");
        Console.WriteLine("4. Divisão (/)");
        

