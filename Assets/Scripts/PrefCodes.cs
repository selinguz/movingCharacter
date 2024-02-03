using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefCodes : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("En Yüksek Skor", 100);
        print(PlayerPrefs.GetFloat("En Yüksek Skor"));

        PlayerPrefs.SetString("Oyuncu Adı", "Can");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
