using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip soundA;//nutrient
    public AudioClip soundB;//nutrient1
    public AudioClip soundC;//obstacle
    public AudioClip soundD;//harder
    void Start()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "nutrient")
            audiosource.PlayOneShot(soundA);
        if (other.tag == "nutrient1")
            audiosource.PlayOneShot(soundB);
        if (other.tag == "Obstacle")
            audiosource.PlayOneShot(soundC);
        if (other.tag == "harder")
            audiosource.PlayOneShot(soundD);



    }



void Update()
    {
        
    }
}
