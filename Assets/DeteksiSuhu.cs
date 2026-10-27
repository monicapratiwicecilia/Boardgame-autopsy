using UnityEngine;
using TMPro; 

public class DeteksiSuhu : MonoBehaviour
{
    public TMP_Text teksSuhu; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mayat"))
        {
            teksSuhu.text = "Suhu mayat: 32°C";
            Debug.Log("Termometer menyentuh Mayat!"); 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mayat"))
        {
            teksSuhu.text = "Arahkan termometer ke mayat...";
        }
    }
}