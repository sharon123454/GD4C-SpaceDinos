using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    public static bool Mode1 = false;
    public static bool Mode2 = false;

    [SerializeField] int cookiesForLvl1 = 20;
    [SerializeField] int cookiesForLvl2 = 40;
    [SerializeField] int cookiesForLvl3 = 60;
    [SerializeField] Transform[] BagSpawnPoints;
    int counter = 0;

    [Header("Mouse Limitations")]
    [SerializeField] float MinXMousePos = -7.4f;
    [SerializeField] float MaxXMousePos = 7.4f;
    [SerializeField] float MinYMousePos = -3.4f;
    [SerializeField] float MaxYMousePos = 3.4f;

    private GameObject hardCookieInCollision;
    private GameObject movableCookieOutCollision;

    void Update()
    {
        Controller();
        
        if (Mode1 && Input.GetMouseButtonDown(0))
            if (hardCookieInCollision)
            {
                Destroy(hardCookieInCollision);
                Collect();
            }

        if (Mode2 && Input.GetMouseButton(0))
        {
            if (movableCookieOutCollision)
            {
                movableCookieOutCollision.transform.position = transform.position;
            }
        }

        movableCookieOutCollision = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Cookie"))
        {
            Destroy(collision.gameObject);
            Collect();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("HCookie") && hardCookieInCollision != collision.gameObject)
            hardCookieInCollision = collision.gameObject;

        if (collision.transform.CompareTag("MCookie"))
            movableCookieOutCollision = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("HCookie") && collision.gameObject == movableCookieOutCollision)
            movableCookieOutCollision = null;
    }

    private void Controller()
    {
        Vector2 _worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float _clamppedX = Mathf.Clamp(_worldMousePos.x, MinXMousePos, MaxXMousePos);
        float _clamppedY = Mathf.Clamp(_worldMousePos.y, MinYMousePos, MaxYMousePos);
        transform.position = new Vector2(_clamppedX, _clamppedY);
    }

    private void Collect()
    {
        if (counter < cookiesForLvl1)
            counter++;
        else if (counter == cookiesForLvl1)
            TriggerMode1();
        else if (counter < cookiesForLvl2)
            counter++;
        else if (counter == cookiesForLvl2)
            TriggerMode2();
        else if (counter < cookiesForLvl3)
            counter++;
        else if (counter >= cookiesForLvl3)
            TriggerMode3();
    }

    private void TriggerMode1()
    {
        Mode1 = true;
        counter++;
    }

    private void TriggerMode2()
    {
        Mode2 = true;
        counter++;
    }

    private void TriggerMode3()
    {
        counter++;
    }

}