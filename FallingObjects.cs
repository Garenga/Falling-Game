using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingObjects : MonoBehaviour
{
    //kada nam je bool pozitivan onda nam je i objekt koji skupljamo
    //kada je negativan bool onda nam je to predmet koji izbjegavamo
    [Header("True = Good Prefab| False = Bad Prefab")]
    public bool isPositive = true;
    GameManager gm;
    //public GameObject[] fallObj;

    private void Start()
    {
        

        gm=FindObjectOfType<GameManager>();//dodjeliti game manager skriptu da se povezuje sa skriptom falling objects tako što unity pretraži hijerahiju i traži skriptu game manager
       // int rng = Random.Range(0, 5);
       // fallObj[rng].SetActive(true);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //radimo prvo za predmet koji player skuplja, bool je pozitivan isPositive
        if (isPositive == true)
        {
            if (other.gameObject.tag == "Player")//ako dotakne playera
            {
                gm.score++;
                other.gameObject.GetComponent<Movement>().Invoke("PlayHitSound", 0f);
                Destroy(this.gameObject);

                if (gm.score >= 20)//ako je score preko 20 pozovi metodu u movement za splash
                {
                    other.gameObject.GetComponent<Movement>().Invoke("PlaySplash",0f);
                }
            }
            if (other.gameObject.tag == "Floor")//ako dotakne pod koji se nevidi
            {
                //if (gm.score > 0) //oduzima bodove ako dotakne tlo
                //{
                //    gm.score--;
                //}
                Destroy(this.gameObject);
            }

        }
        else if (isPositive==false) //za objekte koji oduzimaju hp
        {
            if (other.gameObject.tag == "Player")
            {
                gm.life--;
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "Floor")
            {
                Destroy(this.gameObject);
            }
        }


       
    }
}
