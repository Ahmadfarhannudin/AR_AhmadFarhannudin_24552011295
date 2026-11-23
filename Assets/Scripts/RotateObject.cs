using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Kecepatan putar (derajat per detik), bisa diubah di Inspector
    public float kecepatan = 50f;

    void Update()
    {
        // Berputar pada sumbu Y
        transform.Rotate(0f, kecepatan * Time.deltaTime, 0f, Space.Self);
    }
}