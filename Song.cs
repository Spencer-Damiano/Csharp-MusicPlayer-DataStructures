namespace ds_project;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
    public string Year { get; set; }

    public Song(string title, string artist, string genre, string album, string year)
    {
        Title = title;
        Artist = artist;
        Genre = genre;
        Album = album;
        Year = year;
    }
}