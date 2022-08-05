using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoLvl2 : MonoBehaviour
{
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x < left.transform.position.x)
        { mousePosition.x = left.transform.position.x;}
        if (mousePosition.x > right.transform.position.x)
        {mousePosition.x = right.transform.position.x;}
        transform.position = new Vector3 (mousePosition.x,transform.position.y, transform.position.z);
        print(mousePosition.x);
    }
}
