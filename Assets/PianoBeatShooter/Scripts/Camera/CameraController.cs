////////////////////////////////////////////////////////////
/////   CameraController.cs
/////   James McNeil - 2020
////////////////////////////////////////////////////////////

using UnityEngine;
using Unity.Mathematics;

public class CameraController
{
    private const float k_movementSpeed = 5.0f;
    private const float k_horizontalRotSpeed = 2.0f;
    private const float k_verticalRotSpeed = 2.0f;

    private Transform m_cameraTransform = null;

    public float3 CameraPosition => m_cameraTransform.position;
    public float3 CameraForward => m_cameraTransform.forward;

    public CameraController()
    {
        m_cameraTransform = Camera.main.transform;
    }

    public void Update(float deltaTime)
    {
        UpdateCameraPosition(deltaTime);
        UpdateCameraRotation(deltaTime);
    }
    
    private void UpdateCameraPosition(float deltaTime)
    {
        float3 forward = m_cameraTransform.forward;
        float3 right = m_cameraTransform.right;
        float3 newPos = m_cameraTransform.position;

        float moveDistance = deltaTime * k_movementSpeed;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            newPos += moveDistance * forward;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            newPos -= moveDistance * forward;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            newPos += moveDistance * right;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPos -= moveDistance * right;
        }

        m_cameraTransform.position = newPos;
    }
    
    private void UpdateCameraRotation(float deltaTime)
    {
        float3 eulerAngles = m_cameraTransform.eulerAngles;
        eulerAngles.x -= Input.GetAxis("Mouse Y") * k_verticalRotSpeed;
        eulerAngles.y += Input.GetAxis("Mouse X") * k_horizontalRotSpeed;
        m_cameraTransform.eulerAngles = eulerAngles;
    }
}