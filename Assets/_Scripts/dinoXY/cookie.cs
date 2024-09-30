using UnityEngine;

public class cookie : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;

    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        if (transform.position.y < -10.5)
        {
            cookieManager.lostCookies += 1;
            print(cookieManager.lostCookies);
            Destroy(this.gameObject);
        }

        if (cookieManager.lostCookies > 20)
        {
            //cookieManager.gameOverText.gameObject.SetActive(true);
        }
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cookieManager.cookieCount += 1;
            Destroy(gameObject);

        }
    }

}