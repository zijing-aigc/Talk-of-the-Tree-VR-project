using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
   
    public float speed = 3f;// This stores the movement speed of the GameObject. The default value is 3.0.
    // Start is called before the first frame update
    
    public GameObject onCollectEffect;// particle effect option

 
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
            // Destroy the collectible
            Destroy(gameObject);
        // instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
      
    }

// Update is called once per frame
void Update()
    {
        transform.localPosition += Time.deltaTime * Vector3.forward * speed;// 


    }

    
}