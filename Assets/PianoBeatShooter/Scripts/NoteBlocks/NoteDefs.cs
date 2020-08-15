////////////////////////////////////////////////////////////
/////   NoteDefs.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using UnityEngine;

public enum NoteType
{
    A,
    B,
    BB,
    C,
    C2,
    D,
    E,
    EB,
    F,
    F2,
    G,
    G2,
    COUNT
};

public static class NoteDefs
{
    public static AudioClip[] s_audioClips = Resources.LoadAll<AudioClip>("Audio");

    public static KeyCode[] s_noteKeyMapping = new[]
    {
        KeyCode.A, // A,
        KeyCode.B,// B,
        KeyCode.N,// BB,
        KeyCode.C,// C,
        KeyCode.V,// C2,
        KeyCode.D,// D,
        KeyCode.E,// E,
        KeyCode.R,// EB,
        KeyCode.F,// F,
        KeyCode.D,// F2,
        KeyCode.G,// G,
        KeyCode.H,// G2
    };
}