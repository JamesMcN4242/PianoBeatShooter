////////////////////////////////////////////////////////////
/////   NoteBlock.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using UnityEngine;
using Unity.Mathematics;

public struct NoteBlock
{
    private Transform m_noteTransform;
    private NoteCollider m_colliderNotifier;
    private AudioSource m_audioSource;
    private NoteType m_noteType;
    private float3 m_velocity;

    public NoteBlock(Transform noteTransform, NoteType noteType ,float3 velocity)
    {
        m_noteTransform = noteTransform;
        m_colliderNotifier = noteTransform.GetComponent<NoteCollider>();
        m_audioSource = m_noteTransform.GetComponent<AudioSource>();

        m_noteType = noteType;
        m_velocity = velocity;
    }

    public void UpdatePosition(float deltaTime)
    {
        float3 position = m_noteTransform.position;
        m_noteTransform.position = position + (deltaTime * m_velocity);
    }

    public void PlayAndDestroyObject()
    {
        AudioClip clip = NoteDefs.s_audioClips[(int)m_noteType];
        m_audioSource.clip = clip;
        m_audioSource.Play();
        
        //TODO: Play destruction vfx to hide destruction
        Object.Destroy(m_noteTransform.gameObject, clip.length);
    }

    public bool CollisionMade()
    {
        return m_colliderNotifier.ConsumeCollisionFlag();
    }
}