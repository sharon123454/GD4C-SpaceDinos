using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{

    void Update()
    {
        Vector2 kek = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = kek;
    }
}