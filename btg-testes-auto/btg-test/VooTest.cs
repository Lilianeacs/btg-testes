using btg_testes_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btg_test
{
    public class VooTest
    {
        Voo voo = new("Gol", "437", new DateTime(2023, 12, 09, 19, 45, 0));

        [Fact]
        public void ProximoLivre_Sucesso()
        {
            int resultado = voo.ProximoLivre();

            Assert.InRange(resultado, 0, 100);
        }

        [Fact]
        public void AssentoDisponivel_Sucesso()
        {
            bool resultado = voo.AssentoDisponivel(45);

            Assert.True(resultado);
        }

        [Fact]
        public void AssentoDisponivel_AssentoOcupado()
        {
            voo.OcupaAssento(86);

            bool resultado = voo.AssentoDisponivel(86);

            Assert.False(resultado);
        }

        [Fact]

        public void OcupaAssento_Sucesso()
        {
            bool resultado = voo.OcupaAssento(45);

            Assert.True(resultado);
        }

        [Fact]
        public void QuantidadeVagasDisponivel_Sucesso()
        {
            int resultado = voo.QuantidadeVagasDisponivel();

            Assert.InRange(resultado, 0, 100);
        }

       
        [Fact]
        public void ExibirInformacaoVoo_Sucesso()
        {
            string resultado = voo.ExibeInformacoesVoo();

            Assert.Equal(resultado, "Aeronave Gol registrada sob voo de número 437 para o dia e hora 09/12/2023 19:45:00");
        }
    }
}
