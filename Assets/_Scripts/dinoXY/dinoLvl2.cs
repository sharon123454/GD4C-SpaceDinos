using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoLvl2 : MonoBehaviour
{
    [SerializeField] Transform left;
    [SerializeField] Transform right;
    [SerializeField] float speed = 1;
    [SerializeField] SpriteRenderer sprite;
    //[SerializeField] float minToFlip = 0.05f;


    private void Start()
    {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x < left.transform.position.x)
        { mousePosition.x = left.transform.position.x; }
        if (mousePosition.x > right.transform.position.x)
        { mousePosition.x = right.transform.position.x; }
        if (Mathf.Abs(transform.position.x - mousePosition.x) > 0.2)

        {
            if (transform.position.x < mousePosition.x)
            {
             //   sprite.flipX = true;
            }
            else if (transform.position.x > mousePosition.x)
            {
              //  sprite.flipX = false;
            }
        }
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cookie"))
        {
            soundManager.Instance.playRingCookie();
            soundManager.Instance.PlayChew();
        }
    }
}
