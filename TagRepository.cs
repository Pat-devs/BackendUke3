class TagRepository
{
    private string fileName = "tags.txt"; 

    public void Save(List<TagModel> tagsList)
    {
        
        // before writning to the file we need convert the list of objects to a list of strings

        List<string> lines = new List<string>();

        foreach (TagModel tag in tagsList)
        {
            lines.Add(tag.Name);
        }

        File.WriteAllLines(fileName, lines);
    }
}