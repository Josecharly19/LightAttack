using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance;

    private Camera currentCamera;

    private void Awake()
    {
        Instance = this;
        currentCamera = Camera.main;
    }

    public void SwitchCamera(Camera newCamera)
    {
        if (currentCamera != null)
            currentCamera.gameObject.SetActive(false);

        newCamera.gameObject.SetActive(true);
        currentCamera = newCamera;
    }

    public Camera GetCurrentCamera()
    {
        return currentCamera;
    }
}