namespace TrainingAPI.App
{
    class MusicianDTO
    {
        // Fields
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string song { get; set; }
        public string lyrics { get; set; }

        // Constructor
        public MusicianDTO()
        {
        }

        public MusicianDTO(int id, string username, string password, string song, string lyrics)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.song = song;
            this.lyrics = lyrics;
        }

        // Methods
        public override string ToString()
        {
            return $"{id} {username} {password} {song} {lyrics}";
        }

    }
}