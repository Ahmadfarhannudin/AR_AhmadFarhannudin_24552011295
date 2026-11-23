using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject panelInfo;
    public TMP_Text teksJudul;
    public TMP_Text teksIsi;

    // Dipanggil tombol "Tampilkan/Sembunyikan Info"
    public void ToggleInfo()
    {
        panelInfo.SetActive(!panelInfo.activeSelf);
    }

    // Dipanggil tombol "Keluar"
    public void KeluarAplikasi()
    {
        Debug.Log("Keluar aplikasi");
        Application.Quit();
    }

    // Dipanggil saat target terdeteksi
    public void SetInfo(string judul, string isi)
    {
        teksJudul.text = judul;
        teksIsi.text = isi;
    }
}