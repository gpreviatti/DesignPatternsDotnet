namespace FlyWeight;
internal class Piano
{
    public static void Play(IList<INote> musicNotes) =>
        musicNotes.ToList().ForEach(note =>
        {
            Console.Beep(note.Frequency, 650);
            Console.WriteLine(note.ToString());
        });
}
