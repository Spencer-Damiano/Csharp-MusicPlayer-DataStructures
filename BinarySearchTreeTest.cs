namespace ds_project;

public class BinarySearchTreeTest
{
    public BinarySearchTreeTest()
    {
        MusicLibrary musicLibrary = new MusicLibrary();
        List<Song> yeLibrary = musicLibrary.createYeLibrary();


        Console.WriteLine("\n=========== BINARY SEARCH TREE TESTS: Show Randomize Song List ===========");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Title: {yeLibrary[i].Title}, Artist: {yeLibrary[i].Artist}, Album: {yeLibrary[i].Album}, Year: {yeLibrary[i].Year}");
        }

        BinarySearchTree bst = new BinarySearchTree();

        foreach (var song in yeLibrary)
        {
            bst.Insert(song);        
        }

        Console.WriteLine("\n=========== BINARY SEARCH TREE TESTS: Show Organized Song List ===========");
        bst.InOrderTraversal();
    }
}