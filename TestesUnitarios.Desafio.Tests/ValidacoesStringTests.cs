using System;
using System.Collections.Generic;
using Xunit;
using TestesUnitarios.Desafio.Console.Services;
namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private readonly ValidacoesString _validacoes = new ValidacoesString();
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            var texto = "Matrix";
            var resultadoEsperado = 6;
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);
            Assert.Equal(resultadoEsperado, resultado);
        }
        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);
            Assert.True(resultado);
        }
        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);
            Assert.False(resultado);
        }
        [Fact]
        public void TextoDeveTerminarComAPalavraProcurada()
        {
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado";
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);
            Assert.True(resultado);
        }
        [Fact]
        public void TextoNaoDeveTerCaracteresEspeciais()
        {
            var texto = "Texto sem caracteres especiais";
            var resultado = _validacoes.ContemCaractereEspecial(texto);
            Assert.False(resultado);
        }
        [Fact]
        public void TextoNaoDeveTerEspacosEmBranco()
        {
            var texto = "TextoSemEspacos";
            var resultado = _validacoes.ContemEspacosEmBranco(texto);
            Assert.False(resultado);
        }
        [Fact]
        public void TextoDeveTerNumeros()
        {
            var texto = "Texto com números: 123";
            var resultado = _validacoes.ContemNumeros(texto);
            Assert.True(resultado);
        }
    }
}
