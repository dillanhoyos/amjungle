using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BearTrap : MonoBehaviour
{

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }
    private void BearOpen(){
        AkSoundEngine.PostEvent("BearcClosed", gameObject);
    }
    private void BearClosed(){
        AkSoundEngine.PostEvent("Bearopen", gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<LifeCount>().LoseLife();
        }
    }
}
