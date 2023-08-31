using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefab;//predmet koji se stvara
    public float timer=2f;//vremenski period za stvaranje objekta
    float timerReset;//vraæanje timera na poèetnu vrijednost
    int spawnCount;

    private void Start()
    {
        timerReset = timer;
    }

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int rng = Random.Range(0,5);//za random element u prefab array-u
            float randomPositionX = Random.Range(-4f, 4f); //naredba koja uzima nasumièni broj od -4 do 4 i postavlja ga u varijablu
            Instantiate(prefab[rng], new Vector3(randomPositionX, 15, 0), Quaternion.identity);//stvara objekt na random pozicij x i s vlastiotm rotacijom

            //timer = timerReset;
            timer = Random.Range(0.5f,2f);

            //spawnCount++;

            //if (spawnCount == 13 && timerReset > 0.7f)
            //{
            //    timerReset *= 0.9f;
            //    spawnCount = 0;
            //}
        }

    }
}
