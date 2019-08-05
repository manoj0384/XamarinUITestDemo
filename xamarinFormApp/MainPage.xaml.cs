using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace xamarinFormApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(EntNum1.Text);
            double b = double.Parse(EntNum2.Text);
            Result.Text = (a + b).ToString();
        }

        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(EntNum1.Text);
            double b = double.Parse(EntNum2.Text);
            Result.Text = (a - b).ToString();
        }

        private void BtnMul_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(EntNum1.Text);
            double b = double.Parse(EntNum2.Text);
            Result.Text = (a * b).ToString();
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(EntNum1.Text);
            double b = double.Parse(EntNum2.Text);
            Result.Text = (a / b).ToString();
        }

        private void BtnRem_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(EntNum1.Text);
            double b = double.Parse(EntNum2.Text);
            Result.Text = (a % b).ToString();
        }

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            EntNum1.Text = string.Empty;
            EntNum2.Text = string.Empty;
            Result.Text = string.Empty;
        }
    }
}
