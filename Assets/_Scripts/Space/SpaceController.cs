using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceController : MonoBehaviour
{
    public static bool hardMode = false;
    int counter = 0, cookies4NextLvl = 40;

    [Header("Mouse Limitations")]
    [SerializeField] float MinXMousePos = -7.4f;
    [SerializeField] float MaxXMousePos = 7.4f;
    [SerializeField] float MinYMousePos = -3.4f;
    [SerializeField] float MaxYMousePos = 3.4f;

    void Update()
    {
        Controller();

        if (hardMode && Input.GetMouseButtonDown(0))
            UnlockCookie();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Cookie"))
        {
            Destroy(collision.gameObject);
            Collect();
        }

    }

    private void Controller()
    {
        Vector2 _worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float _clamppedX = Mathf.Clamp(_worldMousePos.x, MinXMousePos, MaxXMousePos);
        float _clamppedY = Mathf.Clamp(_worldMousePos.y, MinYMousePos, MaxYMousePos);
        transform.position = new Vector2(_clamppedX, _clamppedY);
    }

    private void UnlockCookie()
    {

    }

    private void Collect()
    {
        if (counter < cookies4NextLvl)
            counter++;
        else
            TriggerHardMode();
    }

    private void TriggerHardMode()
    {
        hardMode = true;
    }

}