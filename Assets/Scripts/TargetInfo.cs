using UnityEngine;

public class TargetInfo : MonoBehaviour
{
    public UIManager uiManager;
    public string namaObjek;
    [TextArea(3, 6)]
    public string deskripsi;

    // Dipanggil saat target ditemukan
    public void TampilkanInfo()
    {
        uiManager.SetInfo(namaObjek, deskripsi);
    }
}