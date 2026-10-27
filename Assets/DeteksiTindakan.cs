using UnityEngine;
using TMPro; 

public class DeteksiTindakan : MonoBehaviour
{
    public TMP_Text teksInfo; 
    
    [TextArea] // Membuat kolom teks di Unity lebih luas
    public string pesanBukti; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mayat"))
        {
            teksInfo.text = pesanBukti;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mayat"))
        {
            teksInfo.text = "Arahkan alat ke mayat...";
        }
    }
}