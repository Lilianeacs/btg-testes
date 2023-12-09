using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class LucroTest
    {
        [Fact]
        public void CalcularLucro_CompraMenor20()
        {
            // Arrange
            Lucro lucro = new();

            // Act
            decimal resultado = lucro.Calcular(15.50M);

            // Assert
            Assert.Equal(22.4750M, resultado);
        }

        [Fact]
        public void CalcularLucro_CompraMaior20()
        {
            // Arrange
            Lucro lucro = new();

            // Act
            decimal resultado = lucro.Calcular(35.50M);

            // Assert
            Assert.Equal(46.15M, resultado);
        }

       
    }
}
