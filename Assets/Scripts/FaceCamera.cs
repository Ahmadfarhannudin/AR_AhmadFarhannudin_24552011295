using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    void LateUpdate()
    {
        if (Camera.main == null) return;

        // Selaraskan canvas dengan arah kamera
        transform.rotation = Camera.main.transform.rotation;
    }
}