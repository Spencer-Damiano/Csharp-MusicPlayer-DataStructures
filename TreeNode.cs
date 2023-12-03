namespace ds_project;

public class TreeNode
{
    public string AlbumName { get; set; }
    public List<Song> Songs { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(string albumName)
    {
        AlbumName = albumName;
        Songs = new List<Song>();
    }
}