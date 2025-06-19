using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public float countdownTime = 10f;
    private void Update()
    {
        countdownTime -= Time.deltaTime;
        if (countdownTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
