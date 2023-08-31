using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreTextGameOver; //score na kraju koji ide u UI element
    public int scoreGameover;//za pohranu score
    public GameManager gmOver;//refrenca za game manager
    public Spawner spawner;//refrenca za spawner object
    public TextMeshProUGUI pointScore;//refrenca za score


    public void GameOverScreen()
    {
        scoreGameover = gmOver.score;// score ce biti jednak scor-u u game manager-u
        var scoretoText = scoreGameover;
        gameObject.SetActive(true);//aktivira overlay kad se pozove
        scoreTextGameOver.text=scoretoText.ToString()+" POINTS";//ispisuje u text elementa u UI
        gmOver.gameObject.SetActive(false);//gasi game manager
        spawner.gameObject.SetActive(false);//gasi spawner
        pointScore.gameObject.SetActive(false);//gasi score UI element


    }

    
    private void Update()
    {
    }
}
