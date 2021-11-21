using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;
    public Animator anim;

    public void LoseLife()
    {

        AkSoundEngine.PostEvent("Hurt", gameObject);
        livesRemaining--;// Decrease the value of livesRemaining
        anim.Play("frog_hit");
        lives[livesRemaining].enabled = false; // Hide one of the life images
        if (livesRemaining <= 0)  // If we run out of lives we lose the game
        {
            FindObjectOfType<HeroMove>().Die();
        }
    }

    public void BonusLife()
    {
        AkSoundEngine.PostEvent("Bonus_Life", gameObject);
        if (livesRemaining < 4)
        {
            
            livesRemaining++;
            lives[livesRemaining].enabled = true;
        }
        
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
            AkSoundEngine.PostEvent("StopMusic", gameObject);
        }
    }
}
