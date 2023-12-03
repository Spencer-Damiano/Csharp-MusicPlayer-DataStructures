namespace ds_project;

public class MusicController
{
    private LinkedList<Song> _musicController = new LinkedList<Song>();
    private LinkedListNode<Song>? _currentSong;
    
    public void Play()
    {
        // This code is given and does not need testing
        if (_currentSong != null)
        {
            Console.WriteLine("Playing: " + _currentSong.Value.Title); 
        } 
    }
    
    public void SkipSong()
    {
        // PROBLEM X
        // Get the next song in the list. Make sure that there is null error handling
        if (_currentSong != null && _currentSong.Next != null)
        {
            _currentSong = _currentSong.Next;
        }
        
        // this if statement will be given and will not need to be tested
        if (_currentSong == null || _currentSong.Next == null )
        {
            // Reached the end of the playlist
            _currentSong = null;
            Console.WriteLine("End of playlist.");
        }
    }

    public void AddLast(Song song)
    {
        // PROBLEM X
        // Add the song to the playerController. Make sure to add some error handling for a null currentSong 
        _musicController.AddLast(song);
        if (_currentSong == null)
        {
            _currentSong = _musicController.First;
        }
    }


    public void RemoveSong(Song song)
    {
        // PROBLEM X
        // Find a song in the linked list and remove it. 
        var node = _musicController.Find(song);
        if (node != null)
        {
            if (node == _currentSong)
            {
                SkipSong();
            }
            _musicController.Remove(node);
        }
    }

    public void PreviousSong()
    {
        // PROBLEM X
        // Navigate a song back in the linked list
        if (_currentSong != null && _currentSong.Previous != null)
        {
            _currentSong = _currentSong.Previous;
        }
    }

    public void PrintPlaylist()
    {
        foreach (Song song in _musicController)
        {
            Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}, Year: {song.Year}");
        }

        
    }
}