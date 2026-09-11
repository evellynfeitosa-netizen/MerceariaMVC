using MerceariaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerceariaMVCTests
{
    public class ProdutoTests
    {
        [Fact]
        public void Verificar_Preco_Invalido_se_ForMenorqueZero()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Pacote de Salada",
                Preco = 0,
                Estoque = 500
            };

            //Act

            var resultado = produto.Validacao();


            //Assert

            Assert.False(resultado);
        }

        [Fact]
        public void Estoque_Invalido_se_Valor_MenorqueZero()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Muçarela",
                Preco = 45,
                Estoque = -1
            };

            var resulltado = produto.Validacao();

            Assert.False(resulltado);
        }
        [Fact]
        public void VerificarNome_Nulo_ou_Vazio_Invalido()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "",
                Preco = 50,
                Estoque = 45
            };
            //Act
            var resultado = produto.Validacao();
            Assert.False(resultado);
        }
        [Fact]
        public void Verifica_PrecoMaiorqueZero_Estoque_MaiorqueZero_NomeProdutoExistente()
        {
            //Arrange
            var produto = new Produto
            {
                Nome = "Proteína Isolada",
                Preco = 115,
                Estoque = 50
            };
            //Act
            var resultado = produto.Validacao();
            Assert.True(resultado);
        }
    }
}
