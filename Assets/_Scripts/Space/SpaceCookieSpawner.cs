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
    bool allowedToSpawn = true;

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
        {
            int rand = Random.Range(0, 1);

            switch (rand)
            {
                case 0:
                    Instantiate(cookiePrefab, RandomizeSpawnPos(), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(hardCookiePrefab, RandomizeSpawnPos(), Quaternion.identity);
                    break;
            }
        }
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