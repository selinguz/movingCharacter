using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManage : MonoBehaviour
{
    public static int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        coinCount = PlayerPrefs.GetInt(nameof(coinCount), coinCount);
        print(coinCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCoins()
    {
        coinCount++;
        PlayerPrefs.SetInt(nameof(coinCount), coinCount);
    }

    public void DecreaseCoins()
    {
        coinCount--;
        PlayerPrefs.SetInt(nameof(coinCount), coinCount);
    }
}
