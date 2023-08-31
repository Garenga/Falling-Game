using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static SceneManager instance; //mozda nije potrebno

    private void Awake()
    {
        
    }
   public void StartGame()
    {
        SceneManager.LoadScene("Game");//pokrece scenu game
    }

    public void QuitGame()
    {
        Application.Quit();//izlazi iz aplikacije
    }

    public void MainMenuScreen()
    {
        SceneManager.LoadScene("MainMenu");//pokrece scenu main menu
    }
}
