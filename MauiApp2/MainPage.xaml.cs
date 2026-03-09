namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }
        void Zmiana(object sender, TextChangedEventArgs e)
        {
            var Emailwartosc = Email.Text;
            var Password = Haslo.Text;

            if (!string.IsNullOrWhiteSpace(Emailwartosc) && !string.IsNullOrWhiteSpace(Password))
            {
                Zaloguj.IsVisible = true;
            }
            else
            {
                Zaloguj.IsVisible = false;
            }
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Zalogowano", "Zostałeś zalogowany pomyślnie", "OK");
        }
    }
}
