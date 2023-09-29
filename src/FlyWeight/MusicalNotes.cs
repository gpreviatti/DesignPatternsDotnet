namespace FlyWeight;
internal class MusicalNotes
{
    public static IDictionary<string, INote> Notes() => new Dictionary<string, INote>()
    {
        { "do", new Do() },
        { "re", new Re() },
        { "mi", new Mi() },
        { "fa", new Fa() },
        { "sol",new Sol() },
        { "la", new La() },
        { "si", new Si() },
    };

    public static INote GetNote(string note) => Notes()[note];
}
