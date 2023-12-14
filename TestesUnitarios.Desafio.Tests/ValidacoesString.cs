using System.Linq;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }
         public bool ContemCaractereEspecial(string texto)
        {
            return texto.Any(caractere => !char.IsLetterOrDigit(caractere) && !char.IsWhiteSpace(caractere));
        }
    

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }

        public bool ContemEspacosEmBranco(string texto)
        {
            return texto.Any(char.IsWhiteSpace);
        }

        public bool ContemNumeros(string texto)
        {
            return texto.Any(char.IsDigit);
        }
    }
}
