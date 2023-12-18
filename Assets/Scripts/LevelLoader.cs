using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(loadStartDelayed());
        }
    }

    IEnumerator loadStartDelayed()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
    void Update()
    {
        
    }
}
