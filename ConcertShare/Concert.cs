namespace ConcertShare
{
    internal class Concert
    {


        public Concert(string name, string description)
        {
            this.name = name;
            this.description = description;
            // Default Photo
            photoID = Resource.Drawable.no_photo;
        }

        // Add custom photo
        public Concert(string name, string description, int photoID) : this(name, description)
        {
            this.photoID = photoID;
        }

        // Fields
        public string name { get; }
        public string description { get; }
        public int photoID { get; }
    }
}