using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeberS2MiguelPino9noB
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            usuarioConectado.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double ns1 = Convert.ToDouble(notaSeguimiento1.Text);
                if (ns1 > 10 || ns1 < 0)
                {
                    DisplayAlert("Mensaje de alerta", "Error Nota Seguimiento 1: solo numeros del 0 al 10", "OK");
                }
                else
                {
                    double ex1 = Convert.ToDouble(examen1.Text);
                    if (ex1 > 10 || ex1 < 0)
                    {
                        DisplayAlert("Mensaje de alerta", "Error Examen 1: solo numeros del 0 al 10", "OK");
                    }
                    else
                    {
                        double n1 = ns1 * 0.3;
                        double e1 = ex1 * 0.2;
                        double np1 = n1 + e1;
                        notaParcial1.Text = Convert.ToString(np1);

                        double ns2 = Convert.ToDouble(notaSeguimiento2.Text);
                        if (ns2 > 10 || ns2 < 0)
                        {
                            DisplayAlert("Mensaje de alerta", "Error Nota Seguimiento 2: solo numeros del 0 al 10", "OK");
                        }
                        else
                        {
                            double ex2 = Convert.ToDouble(examen2.Text);
                            if (ex2 > 10 || ex2 < 0)
                            {
                                DisplayAlert("Mensaje de alerta", "Error Examen 2: solo numeros del 0 al 10", "OK");
                            }
                            else
                            {
                                double n2 = ns2 * 0.3;
                                double e2 = ex2 * 0.2;
                                double np2 = n2 + e2;
                                notaParcial2.Text = Convert.ToString(np2);
                                if (notaParcial1.Text != null && notaParcial2.Text != null)
                                {
                                    double total = np1 + np2;
                                    notafinal.Text = Convert.ToString(total);
                                    if (total>=7)
                                    {
                                        Estado.Text = "APROBADO";
                                    }else if(total>=5 && total <= 6.9)
                                    {
                                        Estado.Text = "COMPLEMENTARIO";
                                    }else if (total < 5)
                                    {
                                        Estado.Text = "REPROBADO";
                                    }
                                }
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "Error: " + ex.Message, "OK");
            }
        }

        private void Estado_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Estado.Text == "APROBADO")
            {
                Estado.BackgroundColor = Color.Green;
            }
            else if(Estado.Text == "COMPLEMENTARIO")
            {
                Estado.BackgroundColor = Color.Yellow;
            }
            else if(Estado.Text == "REPROBADO")
            {
                Estado.BackgroundColor = Color.Red;
            }
        }
    }
}
