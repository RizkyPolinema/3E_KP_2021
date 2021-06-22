using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Restart ini berfungsi ketika sebuah player kena objek virus, maka gamenya akan berhenti
//Dan untuk mengulang kembali, tinggal pencet tombol R
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //Ini digunakan untuk menginput keyboard yang nantinya akan me-restart game nya
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
