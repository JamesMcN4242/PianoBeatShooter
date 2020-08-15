////////////////////////////////////////////////////////////
/////   BaseGameState.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using System.Collections.Generic;
using PersonalFramework;
using Unity.Mathematics;
using UnityEngine;

public class BaseGameState : FlowStateBase
{
    private CameraController m_cameraController = null;
    private List<NoteBlock> m_noteBlocks = null;
    private GameObject m_notePrefab = null;

    public BaseGameState()
    {
        m_cameraController = new CameraController();
        m_noteBlocks = new List<NoteBlock>(50);
        m_notePrefab = Resources.Load<GameObject>("Prefabs/Note");
    }
    
    protected override void UpdateActiveState()
    {
        float deltaTime = Time.deltaTime;
        m_cameraController.Update(deltaTime);
        UpdateNotes(deltaTime);
    }

    private void UpdateNotes(float deltaTime)
    {
        for (int i = m_noteBlocks.Count - 1; i >= 0; i--)
        {
            m_noteBlocks[i].UpdatePosition(deltaTime);
            if (m_noteBlocks[i].CollisionMade())
            {
                m_noteBlocks[i].PlayAndDestroyObject();
                m_noteBlocks.RemoveAt(i);
            }
        }
    }

    private void CreateNoteBlock(NoteType noteType)
    {
        const float blockSpeed = 4.0f;
        
        GameObject noteObj = Object.Instantiate(m_notePrefab, m_cameraController.CameraPosition, Quaternion.identity);
        NoteBlock note = new NoteBlock(noteObj.transform, noteType, blockSpeed * m_cameraController.CameraForward);
        m_noteBlocks.Add(note);
    }
}