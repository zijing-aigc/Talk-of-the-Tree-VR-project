using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wall : MonoBehaviour
{

    public TextAlignment counterText;
    private int cubeCount = 0;
    private int maxCubes = 200;
    public Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // count cubes
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("nutrient"))
        {
            cubeCount++;


            if (cubeCount >= maxCubes)
            {
                OnStartGameHandler("cp1sc1");
            }

        }
    }
    public void OnStartGameHandler(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}




