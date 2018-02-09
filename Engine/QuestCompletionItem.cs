namespace Engine
{
    public class QuestCompletionItem
    {
        public int Quantity { get; set; }
        public Item Details { get; set; }

        public QuestCompletionItem(Item details, int quantity)
        {
            Quantity = quantity;
            Details = details;
        }
    }
}
