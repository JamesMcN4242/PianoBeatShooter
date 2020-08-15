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
    G2
};

public static class NoteDefs
{
    public static AudioClip[] s_audioClips = Resources.LoadAll<AudioClip>("Audio");
}