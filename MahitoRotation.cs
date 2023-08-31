using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MahitoRotation : MonoBehaviour
{
    public float rotY; 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotY, 0); //za rotaciju mohitoa u gameover overlay-u
    }
}
