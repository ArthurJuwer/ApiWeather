using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ConsumindoApiWeather
{
    public partial class frmWeather : Form
    {
        public frmWeather()
        {
            InitializeComponent();
        }

        string strUrl = "https://api.hgbrasil.com/weather?array_limit=2&fields=only_results,temp,city_name,humidity,sunrise,sunset,condition_slug,rain,condition_code,timezone,wind_speedy,forecast,max,min,date&key=1a4b2896";

        private void Form1_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(strUrl).Result;

                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        TempInf temp = JsonConvert.DeserializeObject<TempInf>(result);

                        lbldata.Text = temp.Date.ToString();
                        lblCidade.Text = temp.City_name + ", Brasil";
                        lblTemp.Text = temp.Temp.ToString();
                        lblSlug.Text = temp.Slug.ToString();
                        lblUmidade.Text = temp.Umidade + "%";
                        lblChuva.Text = temp.Chuva + "mm";
                        lblVento.Text = temp.Vento.ToString();
                        lblAnoitecer.Text = temp.SolPor.ToString();
                        lblAmanhecer.Text = temp.SolSe.ToString();



                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
