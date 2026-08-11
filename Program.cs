namespace BackendUke3;

class Program
{
    static void Main(string[] args)
    {
        // receiving user input tags, example:
        string userInputTags = "coffee, tea,milk";

        // process the tags list and store it as a more useful type
        string[] tagsArray = userInputTags.Split(",");

        // use a list to store the clean tags:
        List<string> tagsList = new List<string>();

        foreach (string tag in tagsArray)
        {
            // clean the tag
            string cleanTag = tag.Trim();

            tagsList.Add(cleanTag);
        }

        Console.WriteLine(tagsList);
    }
}


