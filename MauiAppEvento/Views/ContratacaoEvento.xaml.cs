using MauiAppEvento.Models;

namespace MauiAppEvento.Views;

public partial class ContratacaoEvento : ContentPage
{
	public ContratacaoEvento()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_termino.Date.AddDays(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento h = new Evento
            {
                Descricao = txt_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                QntParticipantes = (int)Convert.ToInt64(stp_participantes.Value),
                Local = txt_local.Text,
            };

            await Navigation.PushAsync(new Eventocontratado() 
            { 
                BindingContext = h 
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "ok!");
        }

    }

    private void dtpck_datainicio_DataSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada = elemento.Date;

        dtpck_inicio.MinimumDate = data_selecionada.AddDays(1);
        dtpck_termino.MaximumDate = data_selecionada.Date.AddDays(6);
    }

}
