namespace ds_project;

class QueueTest
{
    public QueueTest()
    {
        // To find where you need to answer your questions scroll past the test functions

        Playlist playlist = new Playlist(); // Add a queue here and call it playlist

        // Below are some tests that we will use to check your answers.
        //  DO NOT TOUCH ANY OF THE CODE IN THE TEST FUNCTIONS.
        
                string songA = "Hey Driver by Zach Bryan";
                string songB = "Moon River by Frank Ocean";
                string songC = "ballard of a homeschooled girl by Olivia Rodrigo";
        
        // see if your addSong method works
                Console.WriteLine("--------------ADD SONG TEST--------------");
                playlist.addSong(songA); // Should print "Hey Driver by Zach Bryan - added to playlist"
                playlist.addSong(songB); // Should print "Moon River by Frank Ocean - added to playlist"
                playlist.addSong(songC); // Should print "ballard of a homeschooled girl by Olivia Rodrigo - added to playlist"
        
        // check to see if your count method works
                Console.WriteLine("--------------SONG LEFT TEST--------------");
                playlist.songsLeft(); // this should = 3
        
        // check to see if your peek method works
                Console.WriteLine("--------------NEXT SONG TEST--------------");
                playlist.nextSong(); // should be "Hey Driver by Zach Bryan"
        
        // check the removeSong method works
                Console.WriteLine("--------------REMOVE SONG TEST--------------");
                playlist.removeSong();
                playlist.nextSong(); // should be "Moon River by Frank Ocean"
                playlist.songsLeft(); // should be 2
        
    }
}

