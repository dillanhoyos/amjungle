using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullsounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){

      AkSoundEngine.PostEvent("Poison", gameObject);
      
    }

    // Update is called once per frame
   
}
