using System.Reflection.Metadata;
public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
}
public sealed class DocumentRepository
{
    private static readonly Lazy<DocumentRepository> instance =
        new Lazy<DocumentRepository>(() => new DocumentRepository());

    private readonly List<Document> documents;

    private DocumentRepository()
    {
        documents = new List<Document>();
    }

    public static DocumentRepository Instance => instance.Value;

    public void Add(Document document)
    {
        documents.Add(document);
    }

    public List<Document> GetAll()
    {
        return documents;
    }
}