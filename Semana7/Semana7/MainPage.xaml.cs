using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            tbtNew.Clicked += TbtNew_Clicked;
            tbImHome.Clicked += TbImHome_Clicked;
            tbImAbout.Clicked += TbImAbout_Clicked;
            tbtImLogout.Clicked += TbtImLogout_Clicked;
            btnGuardar.Clicked += BtnGuardar_Clicked;
            btnRecuperar.Clicked += BtnRecuperar_Clicked;
            btnBorrar.Clicked += BtnBorrar_Clicked;
        }

        private void BtnBorrar_Clicked(object sender, EventArgs e)
        {
            String nombreArchiv = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchiv);

            if ((File.Exists(rutaCompleta)))
            {
                File.Delete(rutaCompleta);

            }
        }

        private void BtnRecuperar_Clicked(object sender, EventArgs e)
        {
            String nombreArchiv = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchiv);

            if ((File.Exists(rutaCompleta))) {
                using (var lector = new StreamReader(rutaCompleta, true))
                {
                    String TextoLeido;
                    while ((TextoLeido = lector.ReadLine()) != null)
                    {
                        txtRecuperar.Text = TextoLeido;
                    }

                } 

            }
            
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            String nombreArchivo = "prueba.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);


            if (!(File.Exists(rutaCompleta)))
            {
                using (var escritor = File.CreateText(rutaCompleta))
                {
                    escritor.Write(txtguardar.Text);
                }
            }
            else
            {
                using (var escritor = File.AppendText(rutaCompleta))
                {
                    escritor.Write(txtguardar.Text);
                }
            }



        }

        private void TbtImLogout_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Oprime Texto Logoout";
        }

        private void TbImHome_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Oprime Texto Home";
        }

        private void TbImAbout_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Oprime Texto About";
        }

        private void TbtNew_Clicked(object sender, EventArgs e)
        {
            lbl01.Text = "Oprime Texto New";
        }
    }
}
