using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TelaFlutuante
{
    public class ImportScreenConfigLocation
    {
        /// <summary>
        /// Método para importar configurações de localização e tamanho de outro arquivo de configuração.
        /// </summary>
        /// <param name="configPath">Caminho do arquivo de configuração a ser importado.</param>
        public static void ImportConfig(string configPath)
        {
            string caminhoConfigOutraAplicacao = configPath;

            // Prefixo a ser pesquisado
            string prefixo = FormLocation.prefix;

            // Buscar chaves com o prefixo no arquivo de configuração da outra aplicação
            NameValueCollection chavesEncontradas = FindScreenConfig(caminhoConfigOutraAplicacao, prefixo);

            // Salvar as chaves e valores encontrados no arquivo de configuração atual
            foreach (string chave in chavesEncontradas.AllKeys)
            {
                FormLocation.SaveFormLocationFromImport(chave, chavesEncontradas[chave]);
            }
        }

        /// <summary>
        /// Método para buscar chaves com o prefixo especificado em um arquivo de configuração.
        /// </summary>
        /// <param name="caminhoConfig">Caminho do arquivo de configuração a ser pesquisado.</param>
        /// <param name="prefixo">Prefixo a ser pesquisado nas chaves.</param>
        /// <returns>Coleção contendo as chaves e valores encontrados.</returns>
        public static NameValueCollection FindScreenConfig(string caminhoConfig, string prefixo)
        {
            NameValueCollection screenConfigs = new NameValueCollection();

            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoConfig);

            // Selecionar os elementos "add" dentro do elemento "appSettings" que tenham uma chave com o prefixo especificado
            XmlNodeList appSettingsNodes = doc.SelectNodes("//appSettings/add[starts-with(@key, '" + prefixo + "')]");

            // Adicionar as chaves e valores encontrados à coleção de valores
            foreach (XmlNode node in appSettingsNodes)
            {
                screenConfigs.Add(node.Attributes["key"].Value, node.Attributes["value"].Value);
            }

            return screenConfigs;
        }
    }

}
