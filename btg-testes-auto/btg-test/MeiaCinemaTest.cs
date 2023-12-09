using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class MeiaCinemaTest
    {
        [Theory]
        [InlineData(true)]
        [Trait("VerificarMeiaCinema", "Estudante")]
        public void VerificarMeiaCinema_RespostaEstudante(bool resposta)
        {
            //Arrange
            MeiaCinema meiaCinema = new();
            bool estudante = true;
            bool doadorDeSangue = false;
            bool trabalhadorPrefeitura = false;
            bool contratoPrefeitura = false;

            //Act
            bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

            //Assert
            Assert.Equal(resposta, resultado);

        }

        [Theory]
        [InlineData(true)]
        [Trait("VerificarMeiaCinema", "DoadorDeSangue")]
        public void VerificarMeiaCinema_RespostaDoadorDeSangue(bool resposta)
        {
            //Arrange
            MeiaCinema meiaCinema = new();
            bool estudante = false;
            bool doadorDeSangue = true;
            bool trabalhadorPrefeitura = false;
            bool contratoPrefeitura = false;

            //Act
            bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

            //Assert
            Assert.Equal(resposta, resultado);

        }

        [Theory]
        [InlineData(true)]
        [Trait("VerificarMeiaCinema", "Prefeitura")]
        public void VerificarMeiaCinema_RespostaPrefeitura(bool resposta)
        {
            //Arrange
            MeiaCinema meiaCinema = new();
            bool estudante = false;
            bool doadorDeSangue = false;
            bool trabalhadorPrefeitura = true;
            bool contratoPrefeitura = true;

            //Act
            bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

            //Assert
            Assert.Equal(resposta, resultado);

        }

        [Theory]
        [InlineData(false)]
        [Trait("VerificarMeiaCinema", "Falso")]
        public void VerificarMeiaCinema_RespostaFalsa(bool resposta)
        {
            //Arrange
            MeiaCinema meiaCinema = new();
            bool estudante = false;
            bool doadorDeSangue = false;
            bool trabalhadorPrefeitura = false;
            bool contratoPrefeitura = true;

            //Act
            bool resultado = meiaCinema.VerificarMeiaCinema(estudante, doadorDeSangue, trabalhadorPrefeitura, contratoPrefeitura);

            //Assert
            Assert.Equal(resposta, resultado);

        }
    }
}
