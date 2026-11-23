using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    void LateUpdate()
    {
        if (Camera.main == null) return;

        // Canvas menghadap ke kamera
        transform.rotation = Quaternion.LookRotation(
            transform.position - Camera.main.transform.position);
    }
}