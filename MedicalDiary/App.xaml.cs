using MedicalDiary.Infrastructure;
using MedicalDiary.Views;

namespace MedicalDiary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DatabaseSQLite db = new DatabaseSQLite();
            db.InicializarBanco();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}