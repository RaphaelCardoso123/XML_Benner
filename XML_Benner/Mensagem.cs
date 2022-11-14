using System.Xml.Serialization;
using XML_Benner.FMensagem;

namespace XML_Benner
{
   
    [Serialize]
    [XmlRoot("mensagemABI")]

    public class Mensagem
    {

        [XmlElement("cabecalho")]
        public Cabecalho Cabecalho { get; set; }

        [XmlElement("corpoMensagem")]
        public int Corpo { get; set; }

        [XmlElement("epilogo")]
        public Epilogo Epilogo { get; set; }

    }
}
