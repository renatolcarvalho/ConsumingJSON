using SerializerCEP.Model;
using SerializerCEP.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SerializerCEP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private JsonResponse Consultar(string cep)
        {
            //Get String JSON
            string strJSON = JSONHelper.GetJSONString(String.Format("https://viacep.com.br/ws/{0}/json/", cep));

            //Serialize JSON to Object
            JsonResponse jsonResponse = JSONHelper.GetObjectFromJSONString<JsonResponse>(strJSON);

            return jsonResponse;
        }

        private void PreencherInfos(JsonResponse jsonResponse)
        {
            lblCep.Content = jsonResponse.cep;
            lblLocalidade.Content = jsonResponse.localidade;
            lblUF.Content = jsonResponse.uf;
            lblLogradouro.Content = jsonResponse.logradouro;
            lblBairro.Content = jsonResponse.bairro;
            lblComplemento.Content = jsonResponse.complemento;
            lblIBGE.Content = jsonResponse.ibge;
            lblGIA.Content = jsonResponse.gia;

            //Expand
            extenderInfo.IsExpanded = true;
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            JsonResponse jsonResponse = Consultar(txtCEP.Text);
            PreencherInfos(jsonResponse);
        }
    }
}
