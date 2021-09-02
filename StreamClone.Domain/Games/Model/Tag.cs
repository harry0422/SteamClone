namespace StreamClone.Domain.Model.Games
{
    public class Tag
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public Game Game { get; set; }
    }
}