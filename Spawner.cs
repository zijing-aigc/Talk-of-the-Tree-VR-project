using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//It waits for a specific amount of time (beat).
//After the time interval passes, it spawns a random cube at a random spawn point.
//The cube is rotated randomly by 0, 90, 180, or 270 degrees around the Z-axis.
//The process repeats indefinitely.

public class Spawner : MonoBehaviour
{
    public Transform[] bornpoints;//An array of possible spawn points (Transforms) where cubes can appear. These could be different positions in the scene.
    public GameObject[] cubes;//An array of different cube GameObjects. These are the types of cubes that will be spawned at the random spawn points.
    public float beat = 1.4f;//This is the time interval between each spawn, which is set to 1.4 seconds by default.
    float timer = 0;//A timer that tracks how much time has passed since the last cube was spawned. It resets once the cube is spawned.
    bool canSpawnNextCube = true;
    public float startDelay = 10f;//10s
    private bool isStarted = false;//  
    


    // A name to give to the instantiated cube for collision detection purposes.
    //public string bulletName;

    void Start()
    {
        StartCoroutine(StartAfterDelay());

    }

    IEnumerator StartAfterDelay()
    {
        yield return new WaitForSeconds(startDelay);
        isStarted = true;
    }
 

    // Update is called once per frame
    void Update()
    {

        if (!isStarted) return;
        if (timer >= beat)//If the timer reaches the specified "beat" value (1.4 seconds)
        {
            GameObject cube = SpawnCube();//a new cube will be spawned by calling the SpawnCube() method.
            timer = 0;//After spawning the cube, the timer is reset to zero, starting the countdown for the next spawn.
        }
        timer += Time.deltaTime;// If the timer has not yet reached the "beat," the script simply increments the timer by the time elapsed since the last frame(Time.deltaTime).

    
    }

    private GameObject SpawnCube()
    {
        GameObject go = Instantiate(cubes[Random.Range(0, 2)], bornpoints[Random.Range(0, 4)]);//It first randomly picks a cube from the cubes array and a random spawn point from the bornpoints array and It instantiates (creates) the cube at the chosen spawn point
        //go.tag = bulletName;
        go.transform.localPosition = Vector3.zero;//The cube's local position is set to zero (meaning it will be positioned at the exact point of the spawn, not offset).
        go.transform.Rotate(Vector3.forward, 90 * Random.Range(0, 4));//The cube is then rotated randomly by 90, 180, 270, or 0 degrees around the Z-axis using transform.Rotate().
        return go;//Finally, the new cube is returned.
    }

}