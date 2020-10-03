using PueblaContigo.Data;
using PueblaContigo.Services;
using PueblaContigo.Views;
using System;
using System.IO;
using Xamarin.Forms;

namespace PueblaContigo
{
    public partial class App : Application
    {
        //verificamos que exista la base de datso e inicio de app 
        // methodos en los diferentes estados de la app

        static UserRepository users;
        private checkConnection check;
        public static UserRepository Users
        {
            get
            {
                if (users == null)
                {
                    users = new UserRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PueblaContigoU.db3"));
                }
                return users;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new loginPage());
        }

        protected override void OnStart()
        {
            check = new checkConnection();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
