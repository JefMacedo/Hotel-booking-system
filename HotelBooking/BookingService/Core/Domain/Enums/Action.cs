namespace Domain.Enums;

public enum Action
{
    Pay = 0,
    Finish = 1, // Finaliza a reserva depois de pago e usada
    Cancel = 2, // Cancela a reserva antes de ser usada
    Refund = 3, // Devolve o dinheiro da reserva
    Reopen = 4, // Reabre a reserva para ser usada novamente
}
