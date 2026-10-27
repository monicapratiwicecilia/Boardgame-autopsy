using UnityEngine;

public class SingleBodyForensicController : MonoBehaviour
{
    [Header("Komponen Tubuh")]
    // Kita ubah jadi GameObject agar 100% bisa di-drag dari Hierarchy
    public GameObject kulitMayat; 

    [Header("Tekstur Kulit Kasus (Urutan 1-7)")]
    public Texture2D[] caseTextures; 

    [Header("Properti Tambahan (Kosongkan dulu)")]
    public GameObject foamWhite;
    public GameObject foamRed;
    public GameObject ropeMark;
    public GameObject thermometer3D;

    public void ChangeCase(int caseNumber)
    {
        int index = caseNumber - 1;
        
        if (kulitMayat != null && index >= 0 && index < caseTextures.Length)
        {
            // Script akan otomatis mencari komponen Renderer apa pun di objek tersebut
            Renderer renderer = kulitMayat.GetComponent<Renderer>();
            
            // Kalau di luar tidak ada, cari di dalam anak objeknya
            if (renderer == null) 
            {
                renderer = kulitMayat.GetComponentInChildren<Renderer>();
            }

            if (renderer != null)
            {
                renderer.material.mainTexture = caseTextures[index];
                Debug.Log("Berhasil ganti ke tekstur kasus: " + caseNumber);
            }
            else
            {
                Debug.LogError("Gagal: Objek ini tidak punya material/tekstur yang bisa diganti.");
            }
        }
    }
}