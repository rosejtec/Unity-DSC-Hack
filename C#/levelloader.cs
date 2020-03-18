using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelloader : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator transition;
    
    public float transitionTime =1f;
    public const float TIME_LIMIT = 55000F;
    private float timer = 0F;
    // Update is called once per frame
    void Update()
    {
        this.timer += Time.deltaTime;
        if (this.timer>=TIME_LIMIT || Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextLevel();
        }
        
    }
    public void LoadNextLevel()
    {
        if ("RainyScene" == SceneManager.GetActiveScene().name)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex -1));
        }
        else
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

        }
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
            
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(LevelIndex);
        
     }
   
}
