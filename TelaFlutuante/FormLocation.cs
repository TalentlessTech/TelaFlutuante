using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaFlutuante
{
    public class FormLocation
    {
        public static bool saveScreenLocationConfig = false;

        /// <summary>
        /// Prefixo usado para identificar as chaves no arquivo de configuração.
        /// </summary>
        public const string prefix = "ScreenConfig-";

        /// <summary>
        /// Método para salvar a localização e tamanho do formulário no arquivo de configuração ao fechar o formulário.
        /// </summary>
        public static void SaveFormLocation(object sender, FormClosingEventArgs e)
        {
            Form xForm = sender as Form;

            string ScreenName = prefix + xForm.Name;

            // Abrir o arquivo de configuração do executável atual
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            var configValue = config.AppSettings.Settings[ScreenName];

            // Verificar se a chave já existe no arquivo de configuração e atualizá-la ou adicioná-la conforme necessário
            if (configValue != null)
                config.AppSettings.Settings[ScreenName].Value = String.Format("{0};{1};{2};{3}", xForm.Location.X, xForm.Location.Y, xForm.Size.Width, xForm.Size.Height);
            else
                config.AppSettings.Settings.Add(ScreenName, String.Format("{0};{1};{2};{3}", xForm.Location.X, xForm.Location.Y, xForm.Size.Width, xForm.Size.Height));

            // Salvar as alterações no arquivo de configuração
            config.Save(ConfigurationSaveMode.Full);

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Método para salvar a localização e tamanho do formulário a partir de um valor fornecido (usado para importar configurações).
        /// </summary>
        public static void SaveFormLocationFromImport(string Screen, string value)
        {
            string ScreenName = Screen;

            // Abrir o arquivo de configuração do executável atual
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            var configValue = config.AppSettings.Settings[ScreenName];

            // Verificar se a chave já existe no arquivo de configuração e atualizá-la ou adicioná-la conforme necessário
            if (configValue != null)
                config.AppSettings.Settings[ScreenName].Value = value;
            else
                config.AppSettings.Settings.Add(ScreenName, value);

            // Salvar as alterações no arquivo de configuração
            config.Save(ConfigurationSaveMode.Full);

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Método para carregar a localização e tamanho do formulário a partir do arquivo de configuração.
        /// </summary>
        public static int[] LoadFormLocationAndSize(Form xForm, string FormName)
        {
            string ScreenName = prefix + FormName;

            int[] LocationAndSize = new int[] { xForm.Location.X, xForm.Location.Y, xForm.Size.Width, xForm.Size.Height };

            try
            {
                // Abrir o arquivo de configuração do executável atual
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                var configValue = config.AppSettings.Settings[ScreenName];

                // Se a chave existir no arquivo de configuração, atualizar a localização e tamanho do formulário
                if (configValue != null)
                {
                    var configValues = configValue.Value.Split(';');

                    LocationAndSize[0] = Convert.ToInt32(configValues.GetValue(0));
                    LocationAndSize[1] = Convert.ToInt32(configValues.GetValue(1));
                    LocationAndSize[2] = Convert.ToInt32(configValues.GetValue(2));
                    LocationAndSize[3] = Convert.ToInt32(configValues.GetValue(3));
                }
            }
            catch (Exception ex)
            {
                // Exibir uma mensagem de erro caso ocorra uma exceção durante a leitura do arquivo de configuração
                MessageBox.Show(ex.Message);
            }

            return LocationAndSize;
        }

        public static void VerificaConfig()
        {
            string configValue = ConfigurationManager.AppSettings["SaveScreenConfig"];
            if (configValue == "none")
            {

                DialogResult dialogResult = MessageBox.Show("Agora é possível memorizar a localização e tamanhos das janelas!\nDeseja ativar esse recurso?", "Alterar Configuração", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                   
                    SalvarConfiguracao("true"); 
                    FormLocation.saveScreenLocationConfig = true; 
                                                                  
                }
                else
                {
                    
                    SalvarConfiguracao("false"); 
                    FormLocation.saveScreenLocationConfig = false; 
                                                                   
                }
            }
            else
            {
               
                FormLocation.saveScreenLocationConfig = bool.Parse(configValue); 
            }



        }

        public static void SalvarConfiguracao(string valor)
        {
           
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        
            config.AppSettings.Settings["SaveScreenConfig"].Value = valor;

         
            config.Save(ConfigurationSaveMode.Modified);


            ConfigurationManager.RefreshSection("appSettings");
        }

    }

}
