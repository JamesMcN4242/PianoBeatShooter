////////////////////////////////////////////////////////////
/////   PrototypeDirector.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using PersonalFramework;

public class PrototypeDirector : LocalDirector
{
    private void Start()
    {
        m_stateController.PushState(new BaseGameState());
    }
}
