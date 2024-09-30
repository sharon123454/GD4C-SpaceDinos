using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class cookieSpawner : MonoBehaviour
{
    [SerializeField] GameObject cookie;
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] public float intervalLow;
    [SerializeField] public float intervalHigh;

    private GameObject currentCookie;
    private float cookieSpeed;
    private int cookiesSpawned = 0;
    private int minCookieSpeed = 1;
    private int maxCookieSpeed = 5;
    private float interval;

    public void spawn()
    {
        cookiesSpawned++;
        float SpawnXPos = Random.Range(left.transform.position.x, right.transform.position.x);
        float SpawnYPos = Random.Range(left.transform.position.y, right.transform.position.y);
        Vector2 newPos = new Vector2(SpawnXPos, SpawnYPos);

        minCookieSpeed = 1;
        float cookiesOutPrecentage = cookiesSpawned / 50;//every 50 increase min speed
        if (cookiesOutPrecentage > 1) { minCookieSpeed++; }
        else if (cookiesOutPrecentage > 2) { minCookieSpeed += 2; }
        else if (cookiesOutPrecentage > 3) { minCookieSpeed += 3; }

        cookieSpeed = Random.Range(minCookieSpeed, maxCookieSpeed);

        currentCookie = Instantiate(cookie, newPos, Quaternion.identity);
        currentCookie.GetComponent<cookie>().SetSpeed(cookieSpeed);
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