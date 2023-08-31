using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score=0;//broj bodova
    public int life=3;//broj zivota
    public GameOver gameover;//refrenca za gameover skriptu

    private void Update()
    {
        Debug.Log("Score je: " + score+ "\nBroj zivota je: " + life);
        if (Input.GetKeyDown(KeyCode.Escape)) // escape izlazi iz igre mozda cu promjeniti kasnije
        {
            Application.Quit();
            Debug.Log("izaslo je");//samo za editor
        }
        if (life <= 0)
        {
            Debug.Log("Umro si");
            gameover.GameOverScreen();//poziva gameover UI overlay

        }
    }


}
