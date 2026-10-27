using UnityEngine;
using TMPro;

public class BodyRaycastInspector : MonoBehaviour
{
    [Header("UI Teks Petunjuk")]
    public TextMeshProUGUI teksDiLayar;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("🟢 BERHASIL KLIK: " + hit.collider.gameObject.name);

                // NAMA COLLIDER SUDAH DISESUAIKAN DENGAN CONSOLE-MU
                if (hit.collider.gameObject.name == "Collider_Chest")
                {
                    TampilkanPetunjuk("Ada indikasi lebam di dada. Gunakan Kartu Blanching Test!");
                }
                else if (hit.collider.gameObject.name == "Collider_Abdomen")
                {
                    TampilkanPetunjuk("Perut terlihat membengkak. Gunakan Kartu Kaca Pembesar untuk melihat detail pori-pori!");
                }
                else if (hit.collider.gameObject.name == "Collider_Head") // Asumsi nama kepalanya Collider_Head
                {
                    TampilkanPetunjuk("Cek area wajah untuk melihat tanda asfiksia. Gunakan Kartu Senter!");
                }
                else if (hit.collider.gameObject.name == "Collider_Pelvis") // Asumsi nama panggulnya Collider_Pelvis
                {
                    TampilkanPetunjuk("Cek suhu inti tubuh. Gunakan Kartu Termometer pada area ini!");
                }
            }
        }
    }

    void TampilkanPetunjuk(string pesan)
    {
        if(teksDiLayar != null)
        {
            teksDiLayar.text = pesan;
            Debug.Log("🔵 SUKSES: Teks UI sudah diubah!");
        }
    }
}