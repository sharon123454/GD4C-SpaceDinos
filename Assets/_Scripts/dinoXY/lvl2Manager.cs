using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2Manager : MonoBehaviour
{
    [SerializeField] cookieSpawner cookieSpawner;
    [SerializeField] int cookieNeeded;
   

    // Start is called before the first frame update
    void Start()
    {
        soundManager.Instance.intractions2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (cookieManager.cookieCount > cookieNeeded)
        {
            if (cookieSpawner.intervalLow>0.2f)
            {
                cookieSpawner.intervalLow -= 0.5f;
                cookieSpawner.intervalHigh -= 0.5f;                
            }
            if (cookieSpawner.cookieSpeed < 7)
            {
                cookieSpawner.cookieSpeed += 0.1f;
            }
            cookieManager.cookieCount = 0;
        }
    }
}
