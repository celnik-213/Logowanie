namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	void CheckBox_Checked(object sender, EventArgs e)
	{
		var Zgoda = warunki.IsChecked;
		if (Zgoda == true)
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
        DisplayAlert("Zarejestrowano", "Zostałeś zarejestrowany pomyślnie", "OK");
    }
}

/*
***********************************************
    nazwa funkcji: CheckBox_Checked
    opis funkcji: Funkcja sprawdza czy Checkbox jest zaznaczony a następnie odpwoiednio wyświetla lub ukrywa przycisk zalougj się.
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
