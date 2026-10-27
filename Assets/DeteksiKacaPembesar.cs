using UnityEngine;
using TMPro; 

public class DeteksiKacaPembesar : MonoBehaviour
{
    public TMP_Text teksInfo; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mayat"))
        {
            teksInfo.text = "Bukti ditemukan: Terdapat luka lebam benda tumpul!";
            Debug.Log("Kaca Pembesar mendeteksi luka!"); 
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