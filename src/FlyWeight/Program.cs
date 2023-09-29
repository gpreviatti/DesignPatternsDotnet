using FlyWeight;

var musicNotes = new List<INote>()
{
    MusicalNotes.GetNote("do"),
    MusicalNotes.GetNote("re"),
    MusicalNotes.GetNote("mi"),
    MusicalNotes.GetNote("fa"),
    MusicalNotes.GetNote("fa"),
    MusicalNotes.GetNote("fa"),

    MusicalNotes.GetNote("do"),
    MusicalNotes.GetNote("re"),

    MusicalNotes.GetNote("do"),
    MusicalNotes.GetNote("re"),

    MusicalNotes.GetNote("re"),
    MusicalNotes.GetNote("re"),

    MusicalNotes.GetNote("sol"),
    MusicalNotes.GetNote("fa"),
    MusicalNotes.GetNote("la"),
    MusicalNotes.GetNote("mi"),
    MusicalNotes.GetNote("mi"),
    MusicalNotes.GetNote("mi"),

    MusicalNotes.GetNote("do"),
    MusicalNotes.GetNote("re"),
    MusicalNotes.GetNote("mi"),
    MusicalNotes.GetNote("fa"),
    MusicalNotes.GetNote("fa"),
    MusicalNotes.GetNote("fa"),
};

Piano.Play(musicNotes);
