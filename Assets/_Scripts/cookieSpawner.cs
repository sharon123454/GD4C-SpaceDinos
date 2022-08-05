using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieSpawner : MonoBehaviour
{
    [SerializeField] GameObject cookie;
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    private float interval;
    [SerializeField] private float intervalLow;
    [SerializeField] private float intervalHigh;
    private GameObject currentCookie;

    public void spawn()
    {
        float SpawnXPos = Random.Range(left.transform.position.x, right.transform.position.x);
        float SpawnYPos = Random.Range(left.transform.position.y, right.transform.position.y);
        Vector2 newPos = new Vector2(SpawnXPos, SpawnYPos);
        currentCookie = Instantiate(cookie, newPos, Quaternion.identity);
    }

    
     private void Update()
    {
       
        if (interval <= 0)
        {
            interval = Random.Range(intervalLow, intervalHigh);
            spawn();
        }
        else
        {
            interval -= Time.deltaTime;
        }
    }
}