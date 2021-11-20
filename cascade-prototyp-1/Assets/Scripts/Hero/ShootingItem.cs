using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("item"))
        {
            Destroy(gameObject);
        }
    }
}