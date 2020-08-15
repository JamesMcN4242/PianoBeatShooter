////////////////////////////////////////////////////////////
/////   NoteCollider.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using UnityEngine;

[RequireComponent(typeof(Collider))]
public class NoteCollider : MonoBehaviour
{
    private bool m_collisionOccurred = false;

    public bool ConsumeCollisionFlag()
    {
        bool flag = m_collisionOccurred;
        m_collisionOccurred = false;
        return flag;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        m_collisionOccurred = true;
    }
}
