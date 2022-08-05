using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoLvl2 : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            transform.position = new Vector3(hit.transform.position.x, transform.position.y, transform.position.z);
            print("hit: " + hit.transform.position.x);
        }
       
    }
}
