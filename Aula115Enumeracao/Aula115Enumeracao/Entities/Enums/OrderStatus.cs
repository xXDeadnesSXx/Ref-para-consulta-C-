namespace Aula115Enumeracao.Entities.Enums
{
    enum OrderStatus : int//derivado do tipo int
    {
        PendingPayment = 0,//não é obrigatório atribuir um valor o C# atribui automático
        Processing = 1,//a partir do 0
        Shipped = 2,
        Delivered = 3
    }
}
