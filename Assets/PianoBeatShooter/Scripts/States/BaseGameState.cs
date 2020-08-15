////////////////////////////////////////////////////////////
/////   BaseGameState.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using PersonalFramework;
using UnityEngine;

public class BaseGameState : FlowStateBase
{
    private CameraController m_cameraController = null;

    public BaseGameState()
    {
        m_cameraController = new CameraController();
    }
    
    protected override void UpdateActiveState()
    {
        float deltaTime = Time.deltaTime;
        m_cameraController.Update(deltaTime);
    }
}