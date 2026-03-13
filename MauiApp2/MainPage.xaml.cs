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
/*
****************************************************
nazwa funkcji:        Zmiana
opis funkcji:         Funkcja sprawdza czy pola Email oraz Hasło
                      zostały wypełnione. Jeśli oba pola zawierają
                      tekst, przycisk logowania zostaje pokazany.
                      W przeciwnym wypadku przycisk jest ukrywany.
parametry:            Brak
zwracany typ i opis:  Brak
autor:                Wiktor
****************************************************

****************************************************
nazwa funkcji:        OnButtonClicked
opis funkcji:         Funkcja obsługuje kliknięcie przycisku
                      logowania. Po kliknięciu wyświetla komunikat
                      informujący o pomyślnym zalogowaniu użytkownika.
parametry:            Brak
zwracany typ i opis:  Brak
autor:                Wiktor
****************************************************
*/
