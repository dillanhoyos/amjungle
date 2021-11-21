using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playsound(){
         AkSoundEngine.PostEvent("PlaySound", gameObject);
    }
    public void quitsound(){
        AkSoundEngine.PostEvent("quitsound", gameObject);
    }
    public void PlayGame()
    {
        AkSoundEngine.PostEvent("PlaySound", gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoToSettingMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();

    } 

}
