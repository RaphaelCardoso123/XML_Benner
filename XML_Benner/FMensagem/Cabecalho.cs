
namespace XML_Benner.FMensagem
{
    public class Cabecalho
    {
        /// <summary>
        /// Definição do cabeçalho das mensagens
        /// </summary>

        public int IdentificacaoTransacao { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public string VersaoPadrao { get; set; } = "2.00";

    }
}
