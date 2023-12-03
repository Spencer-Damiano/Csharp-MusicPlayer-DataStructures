namespace ds_project;

public class LinkedListsTest
{
    public LinkedListsTest()
    {
        Song song0 = new Song("Song 0", "Winter Whisper", "Classical", "Timeless Echoes", "2018");
        Song song1 = new Song("Song 1", "Luna Ray", "Indie Pop", "Night Whispers", "2021");
        Song song2 = new Song("Song 2", "The Solar Flares", "Rock", "Dawn of Light", "2019");
        Song song3 = new Song("Song 3", "Urban Melody", "Jazz", "Skyline Rhythms", "2020");
        Song song4 = new Song("Song 4", "Skyward Souls", "Electronic", "Ethereal Journeys", "2018");
        Song song5 = new Song("Song 5", "Gentle Echoes", "Ambient", "Soft Serenades", "2022");
        Song song6 = new Song("Song 6", "Marine Vibe", "Reggae", "Beachside Beats", "2021");
        Song song7 = new Song("Song 7", "Desert Dwellers", "Folk", "Sandy Melodies", "2017");
        Song song8 = new Song("Song 8", "City Lights", "Hip Hop", "Urban Pulse", "2019");
        Song song9 = new Song("Song 9", "Astro Nomads", "Psychedelic Rock", "Cosmic Paths", "2020");
        
        
        Console.WriteLine("\n=========== CLASS: MusicController PROBLEM X: AddLast TESTS ===========");
        MusicController musicController = new MusicController();
        musicController.AddLast(song0);
        musicController.AddLast(song1);
        musicController.AddLast(song2);
        musicController.AddLast(song3);
        musicController.AddLast(song4);
        musicController.AddLast(song5);
        musicController.AddLast(song6);
        musicController.AddLast(song7);
        musicController.AddLast(song8);
        musicController.AddLast(song9);
        
        // Assuming you have a method to print the current playlist
        musicController.PrintPlaylist(); // Expected output should show [SONG NAMES HERE] in order
        
        Console.WriteLine("\n=========== CLASS: MusicController PROBLEM X: RemoveSong TESTS ===========");
        musicController.RemoveSong(song3);
        musicController.PrintPlaylist(); // Expected output should show song1 and song3, with song2 removed
        
        Console.WriteLine("\n=========== CLASS: MusicController PROBLEM X: SkipSong TESTS ===========");
        musicController.Play(); // Expected output should show show "Song 0"
        musicController.SkipSong();
        musicController.Play(); // Expected output should show show "Song 1"
        musicController.SkipSong();
        musicController.Play(); // Expected output should show show "Song 2"
        musicController.SkipSong();
        musicController.Play(); // Expected output should show show "Song 4", remember we removed "Song 3"
        musicController.SkipSong();
        musicController.Play();
        
        
        Console.WriteLine("\n=========== CLASS: MusicController PROBLEM X: PreviousSong TESTS ===========");
        musicController.PreviousSong();
        musicController.Play(); // Expected output should show "Song 4"
    }
}