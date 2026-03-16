namespace MauiApp2;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void PickerPriorytet(object sender, EventArgs e)
    {
		if (tematPicker.SelectedIndex == 0)
		{
			priorytetPicker.IsEnabled = true;
			priorytetPicker.ItemsSource = new List<string> { "Niski", "Średni", "Wysoki" };
		}
		else if (tematPicker.SelectedIndex == 1)
		{
			priorytetPicker.IsEnabled = true;
			priorytetPicker.ItemsSource = new List<string> { "Niski", "Średni" };
		}
		else
		{
			priorytetPicker.IsEnabled = false;
			priorytetPicker.SelectedIndex = -1;
        }
    }
	
	void OnButtonClicked(object sender, EventArgs e)
	{
		var imie1 = imie.Text;
		var email1 = email.Text;
		var temat1 = tematPicker.SelectedItem;
		var priorytet1 = priorytetPicker.SelectedItem;
		if (priorytet1 == null) priorytet1 = "Brak";
		var kopia1 = kopia.IsChecked;

		if (!string.IsNullOrWhiteSpace(imie1) && !string.IsNullOrWhiteSpace(email1) && temat1 != null && kopia1 == true)
		{
            DisplayAlert("Wysłano", "Wszystko zostało wypełnione poprawnie oczekuj odpowiedzi.", "OK");
        }
		else
		{
			DisplayAlert("Błąd", "Proszę wypełnić wszystkie pola i zaznaczyć zgodę na otrzymywanie kopii wiadomości.", "OK");
        }
    }
}
/*
***********************************************
    nazwa funkcji: PickerPriorytet
    opis funkcji: Funkcja sprawdza czy która z opcji została wybrana a następnie wyświelta odpowiednie opcje.
    parametry: Brak
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
***********************************************
    nazwa funkcji: OnButtonClicked
    opis funkcji: Funkcja po naciśnięciu wyświelta alert.
    parametry: Brak
    zwracany typ i opis: Brak
    autor: Wiktor
************************************************
*/
