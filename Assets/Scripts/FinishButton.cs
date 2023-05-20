using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButton : MonoBehaviour
{
    private int _levelGenerate;



    public void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        currentScene++;

        if (currentScene > 4)
        {
            _levelGenerate = Random.Range(2, 4);
            SceneManager.LoadScene(_levelGenerate);
        }

        else
        {
            SceneManager.LoadScene(currentScene);
        }
        // Start is called before the first frame update
    }
}
