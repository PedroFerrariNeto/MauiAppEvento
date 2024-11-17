namespace MauiAppEvento.Models
{
    internal class Evento
    {
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int QntParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public int DuracaoEvento { get => DataTermino.Subtract(DataInicio).Days; }
        public double CustoParticipante => 100.0;
        public double Custo => CustoParticipante * QntParticipantes;
        public double CustoEvento
        {
            get
            {
                if (DuracaoEvento == 0)
                {
                    double Total = Custo;
                    return Total;
                }
                else
                {
                    double Total = (Custo * DuracaoEvento) + Custo;
                    return Total;
                }

            }
        }
    }
}
