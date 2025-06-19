using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float actionTime = 12f;


// Start is called before the first frame update
void Start()
{
        Destroy(gameObject, actionTime);
}

        
    
}
