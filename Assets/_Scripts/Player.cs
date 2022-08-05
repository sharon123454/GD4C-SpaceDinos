using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public Transform Dino;

    private void Awake()
    {
        if (Instance == null && Instance != this)
            Destroy(Instance);

        Instance = this;
    }

    private void Update()
    {
        if (Dino.position != Input.mousePosition)
        {
            //lerp to playerS
        }
    }

}