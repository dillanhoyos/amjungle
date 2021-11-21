using UnityEngine;
using UnityEngine.Events;

public class ShootingAction : MonoBehaviour
{
    public int health;
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        AkSoundEngine.PostEvent("EnemyDeath", gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            health -= 6;
        }
    }
}