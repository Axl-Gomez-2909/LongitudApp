using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LongitudApp.ViewModels
{
    public partial class MetroViewModel : ObservableObject
    {
        [ObservableProperty]
        private double valorMetro;

        [ObservableProperty]
        private double resultado;
        [RelayCommand]
        private void Conversion()
        {
            try
            {

                Resultado = ValorMetro * 100;

            }
            catch (Exception ex)
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            ValorMetro = Resultado = 0;
        }
    }
}

