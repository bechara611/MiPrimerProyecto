using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MiprimerProyecto
{

    using Views;
    public partial class App : Application
    {
        #region CONSTRUCTOR
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        #endregion

        #region metodos
        protected override void OnStart() //cuando inicia 
        {
            // Handle when your app starts
        }

        protected override void OnSleep() //cuando minimizas
        {
            // Handle when your app sleeps
        }

        protected override void OnResume() //cuando la vuelves abrir
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
