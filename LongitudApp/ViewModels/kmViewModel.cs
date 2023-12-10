using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LongitudApp.ViewModels
{
    public partial class kmViewModel : ObservableObject
    {
        [ObservableProperty]
        private double valorKm;

        [ObservableProperty]
        private double resultado;
        [RelayCommand]
        private void Conversion()
        {
                try
                {
              
                        Resultado = ValorKm * 1000;
              
                }
                catch (Exception ex)
                {
                    MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
                }
        }

        [RelayCommand]
        private void Limpiar()
        {
            ValorKm = Resultado = 0;
        }
    }
}

