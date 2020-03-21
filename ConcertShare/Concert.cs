namespace ConcertShare
{
    internal class Concert
    {
 

        public Concert(string name, string description)
        {
                this.name = name;
                this.description = description;
        }

        public string name { get; }

        public string description { get; }
    }
}