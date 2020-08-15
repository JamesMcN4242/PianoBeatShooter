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
    public static readonly AudioClip[] s_audioClips = Resources.LoadAll<AudioClip>("Audio");

    public static readonly KeyCode[] s_noteKeyMapping = {
        KeyCode.A,  // A,
        KeyCode.B,  // B,
        KeyCode.N,  // BB,
        KeyCode.C,  // C,
        KeyCode.V,  // C2,
        KeyCode.D,  // D,
        KeyCode.E,  // E,
        KeyCode.R,  // EB,
        KeyCode.F,  // F,
        KeyCode.T,  // F2,
        KeyCode.G,  // G,
        KeyCode.H,  // G2
    };
}