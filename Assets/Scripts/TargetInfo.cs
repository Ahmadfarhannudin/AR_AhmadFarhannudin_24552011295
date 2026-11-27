using UnityEngine;
using Vuforia;

public class TargetInfo : MonoBehaviour
{
    public UIManager uiManager;
    public string namaObjek;
    [TextArea(3, 6)]
    public string deskripsi;

    ObserverBehaviour observer;

    void Awake()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (uiManager == null)
            uiManager = FindFirstObjectByType<UIManager>();
    }

    void OnEnable()
    {
        if (observer != null)
            observer.OnTargetStatusChanged += OnStatusChanged;
    }

    void OnDisable()
    {
        if (observer != null)
            observer.OnTargetStatusChanged -= OnStatusChanged;
    }

    void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED)
        {
            TampilkanInfo();
        }
    }

    // Mengisi panel informasi dengan data objek ini
    public void TampilkanInfo()
    {
        if (uiManager == null) return;
        Debug.Log("Info ditampilkan: " + namaObjek);
        uiManager.SetInfo(namaObjek, deskripsi);
    }
}