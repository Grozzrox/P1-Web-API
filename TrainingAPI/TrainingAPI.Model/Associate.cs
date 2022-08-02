namespace TrainingAPI.Model
{
    public class Associate
    {
        // Fields
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string song { get; set; }
        public string lyrics { get; set; }

        // Constructor

        public Associate() { }

        public Associate(int id, string username, string password, string song, string lyrics)
        {
            Id = id;
            this.username = username;
            this.password = password;
            this.song = song;
            this.lyrics = lyrics;
        }

        // Methods
    }
}