namespace ds_project;

public class BinarySearchTree
{
    private TreeNode root;

    public void Insert(Song song)
    {
        root = InsertSong(root, song);
    }

    private TreeNode InsertSong(TreeNode node, Song song)
    {
        if (node == null)
        {
            TreeNode newNode = new TreeNode(song.Album);
            newNode.Songs.Add(song);
            return newNode;
        }

        int result = string.Compare(song.Album, node.AlbumName);
        if (result < 0)
        {
            node.Left = InsertSong(node.Left, song);
        }
        else if (result > 0)
        {
            node.Right = InsertSong(node.Right, song);
        }
        else
        {
            // Same album, add the song to the current node's list
            node.Songs.Add(song);
        }

        return node;
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.WriteLine("\nAlbum: " + node.AlbumName);
            foreach (var song in node.Songs)
            {
                Console.WriteLine(" - Song: " + song.Title);
            }
            InOrderTraversal(node.Right);
        }
    }
}