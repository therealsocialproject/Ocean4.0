using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed.
        UnityEngine.SceneManagement.SceneManager.LoadScene("Play_Scene");
		Debug.Log("Sent to Play_Scene");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits_Scene");
		Debug.Log("Sent to Credits_Scene");
    }

    public void BackButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main_Menu");
        Debug.Log("Sent to main menu");

    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }

    public void DebugLevelButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Debug_Scene");
		Debug.Log("Sent to Debug_Scene");
    }
}