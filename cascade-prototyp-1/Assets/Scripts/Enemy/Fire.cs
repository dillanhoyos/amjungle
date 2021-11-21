using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

private void Start(){
               AkSoundEngine.PostEvent("Fire", gameObject);
}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           
          FindObjectOfType<LifeCount>().LoseLife();
        }
    }
}
