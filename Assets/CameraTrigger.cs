using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera newCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CameraManager.Instance.SwitchCamera(newCamera);
        }
    }
}