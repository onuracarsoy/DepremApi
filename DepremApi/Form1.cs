using DepremApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DepremApi.Models.EarthquakeViewModel;


namespace DepremApi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        //*************************************
        //Apinin Json ile Deserialize edilmesi*
        //*************************************
        public async Task EarthquakeApi(EarthquakeViewModel model)
        {
            //Apimizin Url'si
            string apiUrl = "https://api.orhanaydogdu.com.tr/deprem/kandilli/live";

            //HttpCient 
            using (var httpClient = new HttpClient())
            {
                try
                {
                    //Verilerimizi Get ile çekiyoruz
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

 
                    if (response.IsSuccessStatusCode)
                    {
                        //Verilerimizi Json ile okuyoruz
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        //Çözümlüyoruz
                        var values = JsonConvert.DeserializeObject<dynamic>(jsonContent);


                        //Döngü ile DataGride Bastırıyoruz
                        foreach (var earthquake in values.result)
                        {            
                            dataGridView1.Rows.Add(
                                earthquake.date, //Tarih
                                earthquake.title, //Yer - Şehir
                                earthquake.mag,// Büyüklük
                                earthquake.depth, //Derinlik
                                earthquake.geojson.coordinates //Koordinatlar
                                );

                            //Eğer belirttiğimiz sayıdan büyük ise uyarı verdiriyoruz
                            if (earthquake.mag > 3)
                            {
                                //Uyarı sesi çalıyor
                                PlayBackSound();

                                //Mesaj veriliyor
                                DialogResult result=  MessageBox.Show($"Error: {earthquake.title} adlı deprem büyüklüğü {earthquake.mag}.");

                                //Okeylenirse ses kapanıyor
                                if (result == DialogResult.OK)
                                {
                                    StopBackSound();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"API isteği başarısız: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Hata oluştu: {e.Message}");
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGrid de verilere görmemiz için api metodumuzu çağırıyoruz
            EarthquakeViewModel model = new EarthquakeViewModel();
            EarthquakeApi(model);
        }



        //*******************************************************
        //Timer nesnesi ile 1 dakikada bir veriler güncelleniyor*
        //*******************************************************
        private void InitializeTimer()
        {
            // Timer nesnesini oluştur
            Timer timer = new Timer();
            timer.Interval = 60000; // 1 dakika (60000 milisaniye)
            timer.Tick += timer1_Tick;

            // Timer'ı başlat
            timer.Start();
        }


        //**********************************************
        //Timer süresi bittiğinde veriler güncelleniyor*
        //**********************************************
        private async void timer1_Tick(object sender, EventArgs e)
        {
            EarthquakeViewModel model = new EarthquakeViewModel();
            await EarthquakeApi(model);
        }

        //****************
        //Ses çalıştırma *
        //****************
        private void PlayBackSound()
        {
            try
            {
                
                using (var player = new SoundPlayer())
                {
                    // Ses dosyasının proje dizinindeki yolunu belirttik(ben bilgisayardan belirttim)
                    string soundFilePath = "C:\\Users\\User\\source\\repos\\DepremApi\\DepremApi\\Sound\\warning.wav";
                    player.SoundLocation = soundFilePath;

                    // Ses dosyasını çaldırdık
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Geri dönüş sesini çalma hatası: {ex.Message}");
            }
        }

        //*************
        //Ses kapatma *
        //*************
        private void StopBackSound()
        {
           SoundPlayer player = new SoundPlayer();
            try
            {
          
                if (player != null)
                {
                    //Sesi durdurduk
                    player.Stop();
                    player.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Geri dönüş sesini durdurma hatası: {ex.Message}");
            }
        }

       
    }
}

