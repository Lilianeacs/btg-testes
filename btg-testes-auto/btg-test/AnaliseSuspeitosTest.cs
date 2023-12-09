using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class AnaliseSuspeitosTest
    {
        [Theory]
        [InlineData("Suspeita")]
        [Trait("ExecutarQuestionarioSuspeito", "Suspeita")]
        public void ExecutarQuestionarioSuspeito_ComRespostaSuspeita(string resposta)
        {
            // Arrange
            AnaliseSuspeitos analiseSuspeitos = new();
            bool telefonouVitima = true;
            bool esteveNoLocal = true;
            bool moraPerto = false;
            bool devedor = false;
            bool trabalhaComVitima = false;

            // Act
            string resultado = analiseSuspeitos.ExecutarQuestionarioSuspeito(telefonouVitima,
                                                          esteveNoLocal,
                                                          moraPerto,
                                                          devedor, trabalhaComVitima);

            // Assert
            Assert.Equal(resultado, resposta);

        }

        [Theory]
        [InlineData("Cúmplice")]
        [Trait("ExecutarQuestionarioSuspeito", "Cúmplice")]
        public void ExecutarQuestionarioSuspeito_ComRespostaCumplice_Com3Positivo(string resposta)
        {
            // Arrange
            AnaliseSuspeitos analiseSuspeitos = new();
            bool telefonouVitima = true;
            bool esteveNoLocal = true;
            bool moraPerto = true;
            bool devedor = false;
            bool trabalhaComVitima = false;

            // Act
            string resultado = analiseSuspeitos.ExecutarQuestionarioSuspeito(telefonouVitima,
                                                          esteveNoLocal,
                                                          moraPerto,
                                                          devedor, trabalhaComVitima);

            // Assert
            Assert.Equal(resultado, resposta);

        }

        [Theory]
        [InlineData("Cúmplice")]
        [Trait("ExecutarQuestionarioSuspeito", "Cúmplice")]
        public void ExecutarQuestionarioSuspeito_ComRespostaCumplice_Com4Positivo(string resposta)
        {
            // Arrange
            AnaliseSuspeitos analiseSuspeitos = new();
            bool telefonouVitima = true;
            bool esteveNoLocal = true;
            bool moraPerto = true;
            bool devedor = true;
            bool trabalhaComVitima = false;

            // Act
            string resultado = analiseSuspeitos.ExecutarQuestionarioSuspeito(telefonouVitima,
                                                          esteveNoLocal,
                                                          moraPerto,
                                                          devedor, trabalhaComVitima);

            // Assert
            Assert.Equal(resultado, resposta);

        }

        [Theory]
        [InlineData("Assassino")]
        [Trait("ExecutarQuestionarioSuspeito", "Assassino")]
        public void ExecutarQuestionarioSuspeito_ComRespostaAssassino(string resposta)
        {
            // Arrange
            AnaliseSuspeitos analiseSuspeitos = new();
            bool telefonouVitima = true;
            bool esteveNoLocal = true;
            bool moraPerto = true;
            bool devedor = true;
            bool trabalhaComVitima = true;

            // Act
            string resultado = analiseSuspeitos.ExecutarQuestionarioSuspeito(telefonouVitima,
                                                          esteveNoLocal,
                                                          moraPerto,
                                                          devedor, trabalhaComVitima);

            // Assert
            Assert.Equal(resultado, resposta);

        }

        [Theory]
        [InlineData("Inocente")]
        [Trait("ExecutarQuestionarioSuspeito", "Inocente")]
        public void ExecutarQuestionarioSuspeito_ComRespostaInocente(string resposta)
        {
            // Arrange
            AnaliseSuspeitos analiseSuspeitos = new();
            bool telefonouVitima = false;
            bool esteveNoLocal = false;
            bool moraPerto = false;
            bool devedor = false;
            bool trabalhaComVitima = false;

            // Act
            string resultado = analiseSuspeitos.ExecutarQuestionarioSuspeito(telefonouVitima,
                                                          esteveNoLocal,
                                                          moraPerto,
                                                          devedor, trabalhaComVitima);

            // Assert
            Assert.Equal(resultado, resposta);

        }
    }
}
