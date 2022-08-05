using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCookieSpawner : MonoBehaviour
{
    [SerializeField] GameObject cookiePrefab;
    [SerializeField] GameObject hardCookiePrefab;

    [Header("Spawn Area Objects")]
    [SerializeField] Transform topRight;
    [SerializeField] Transform bottomLeft;
    [SerializeField] float spawnAmount, timeBetweenSpawn;
    bool allowedToSpawn = false;

    private void Update()
    {
        if (allowedToSpawn)
            SpawnCookie();

    }

    private void SpawnCookie()
    {
        if (!SpaceController.hardMode)
            NormalCookie();
        else
            HardCookie();

        Invoke("ResetTimer", timeBetweenSpawn);
    }

    private void NormalCookie()
    {

    }

    private void HardCookie()
    {

    }

    private void ResetTimer()
    {
        allowedToSpawn = true;
    }

}