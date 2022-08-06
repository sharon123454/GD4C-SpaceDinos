using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCookieSpawner : MonoBehaviour
{
    [SerializeField] GameObject cookiePrefab;
    [SerializeField] GameObject hardCookiePrefab;
    [SerializeField] GameObject movablePrefab;
    [SerializeField] GameObject movableCollector;

    [Header("Spawn Area Objects")]
    [SerializeField] Transform topRight;
    [SerializeField] Transform bottomLeft;
    [SerializeField] float spawnAmount, timeBetweenSpawn;
    bool allowedToSpawn = true;

    private void Update()
    {
        if (allowedToSpawn)
            SpawnCookie();
    }

    private void SpawnCookie()
    {
        if (!SpaceController.Mode1)
            NormalCookie();
        else
            HardCookie();

        allowedToSpawn = false;
        Invoke("ResetTimer", timeBetweenSpawn);
    }

    private void NormalCookie()
    {
        for (int i = 0; i < spawnAmount; i++)
            Instantiate(cookiePrefab, RandomizeSpawnPos(), Quaternion.identity);
    }

    private void HardCookie()
    {
        for (int i = 0; i < spawnAmount; i++)
            Instantiate(hardCookiePrefab, RandomizeSpawnPos(), Quaternion.identity);
    }

    private void MovableCookie()
    {
        Instantiate(movablePrefab, RandomizeSpawnPos(), Quaternion.identity);
        Instantiate(movableCollector, RandomizeSpawnPos(), Quaternion.identity);
    }

    private Vector2 RandomizeSpawnPos()
    {
        float _randX = Random.Range(bottomLeft.transform.position.x, topRight.transform.position.x);
        float _randy = Random.Range(bottomLeft.transform.position.y, topRight.transform.position.y);
        return new Vector2(_randX, _randy);
    }

    private void ResetTimer()
    {
        allowedToSpawn = true;
    }
}