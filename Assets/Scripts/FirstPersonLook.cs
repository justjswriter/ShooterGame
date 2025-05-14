using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (firstPersonCamera.enabled)
            {
                firstPersonCamera.enabled = false;
                thirdPersonCamera.enabled = true;
            }
            else
            {
                firstPersonCamera.enabled = true;
                thirdPersonCamera.enabled = false;
            }
        }
    }
}