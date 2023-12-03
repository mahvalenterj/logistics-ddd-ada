public sealed class PurchaseNotification : BaseEntity
{
    public string RecipientName { get; set; }
    public string PurchaseDescription { get; set; }
    public string RecipientCep { get; set; }

    // Adicione uma propriedade de navegação para representar a entrega associada a esta notificação
    public Delivery Delivery { get; set; }
}
