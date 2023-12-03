namespace ds_project;

public class Playlist
{
    private Queue<string> _playlist = new Queue<string>();

    public void addSong(string song)
    {
        // PROBLEM ONE
        // using the Enqueue function add a song to the playlist and then print what song was just added.
        _playlist.Enqueue(song);
        
        Console.WriteLine($"{song} - added to playlist");
    }
    public void songsLeft()
    {
        // PROBLEM FOUR
        // Using the count function, see how many songs are left, and print it out.
        Console.WriteLine($"Songs left = {_playlist.Count}");
    }

    public void nextSong()
    {
        // PROBLEM TWO
        // Using the Peek function, check what song comes next and then print it out.
        Console.WriteLine(_playlist.Peek()); 
    }

    public void removeSong()
    {
        // PROBLEM THREE
        // Using the Dequeue function, remove a song from the list
        _playlist.Dequeue();
    }

    
    // If you have finished the problems and would like a challenge, see if you can add a song anywhere within the queue

    public Queue<string> TestPlaylist()
    {
        return _playlist;
    }
}