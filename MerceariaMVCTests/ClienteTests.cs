using MerceariaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerceariaMVCTests
{

    public class ClienteTests
    {
        [Fact]
        public void Verificar_Idade_Menor_Dezoito_Invalido()
        {
            var cliente = new Cliente
            {
                Nome = "Evellyn",
                Email = "evellyn01@gmail.com",
                Idade = 17,
                Ativo = true
            };
            var resultado = cliente.Validacao();

            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Email_Valido()
        {
            var cliente = new Cliente
            {
                Nome = "Evellyn",
                Email = "evellynemail",
                Idade = 17,
                Ativo = true
            };
            var resultado = cliente.Validacao();
            Assert.False(resultado);
        }
        [Fact]
        public void Verificar_Nome_Nulo_ou_Vazio()
        {
            var cliente = new Cliente
            {
                Nome = "",
                Email = "evellyn01@gmail.com",
                Idade = 17,
                Ativo = true
            };
            var resultado = cliente.Validacao();
            Assert.False(resultado);
        }
        [Fact]
        public void Cliente_Inativo()
        {
            var cliente = new Cliente
            {
                Nome = "Evellyn",
                Email = "evellyn01@gmail.com",
                Idade = 17,
                Ativo = true
            };
            var resultado = cliente.Permissao();

            Assert.False(resultado);
        }
        [Fact]
        public void Cliente_Apto_Para_Compra()
        {
            var cliente = new Cliente
            {
                Nome = "Evellyn",
                Email = "evellyn01@gmail.com",
                Idade = 21,
                Ativo = true
            };
            var resultado = cliente.Permissao();

            Assert.True(resultado);

        }
    }
}
