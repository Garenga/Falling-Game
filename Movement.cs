using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;//vrijednost za brzinu kretanja
    public GameManager scoreChanges;//mjenjamo mesh ovisno o score-u

    public GameObject starting;
    public GameObject withStraw;
    public GameObject withStrawAndDrink;

    public ParticleSystem splash;

    public AudioSource dropAudio;//audio source za kad nešto upadne u casu
    public AudioClip emptyCupClip;
    public AudioClip withStrawCupClip;
    public AudioClip strawAndDrinkCupClip;


    //u startu dodaojemo rb u skriptu
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        starting.SetActive(true);

    }

    private void Update()
    {
 
        PlayerMovement();
        ShapeChange();
    }

    private void PlayerMovement() //metoda za detekciju tipki za kretanje
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed,ForceMode.Acceleration);
        }
    }

    void ShapeChange() //ne radi
    {
        if (scoreChanges.score >= 10 && scoreChanges.score < 20)
        {
            starting.SetActive(false);
            withStraw.SetActive(true);
            withStrawAndDrink.SetActive(false);
        }

        else if(scoreChanges.score >= 20)
        {
            starting.SetActive(false);
            withStraw.SetActive(true);
            withStrawAndDrink.SetActive(true);
        }
        else
        {
            starting.SetActive(true);
            withStraw.SetActive(false);
            withStrawAndDrink.SetActive(false);
        }
    }

    void PlaySplash()//za splash particle, poziva se iz FallingObjects skripte
    {
        splash.Play();
    }

    void PlayHitSound()
    {
        if (starting.activeInHierarchy)
        {
            dropAudio.clip = emptyCupClip;
            dropAudio.Play();
        }
        else if( withStraw.activeInHierarchy && withStrawAndDrink.activeInHierarchy==false)
        {
            dropAudio.clip = withStrawCupClip;
            dropAudio.Play();
        }
        else if (withStrawAndDrink.activeInHierarchy && withStraw.activeInHierarchy)
        {
            dropAudio.clip = strawAndDrinkCupClip;
            dropAudio.Play();
        }
    }
}
