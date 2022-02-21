namespace SerializationBehavior.DataModel
{
    public abstract class ItemBase
    {
        public abstract string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
