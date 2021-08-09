using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator crossFade;
    public Animator musicCrossFade;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        crossFade.SetTrigger("Start");
        musicCrossFade.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 - scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
    }
}
