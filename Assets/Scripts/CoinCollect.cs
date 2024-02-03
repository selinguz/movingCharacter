using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("coinToCollect"))
        {
            CoinManage.coinCount++;
            Destroy(collider.gameObject);
            print(CoinManage.coinCount);
        }
    }
}
