using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public AudioSource bounceSound;
    // Start is called before the first frame update
    void Start()
    {
        bounceSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //bounceSound.Play();
    }
}
