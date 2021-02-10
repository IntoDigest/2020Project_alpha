using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene_sto : MonoBehaviour
{
    public string sceneToLoad;
    void Start()
    {
        StartCoroutine(sp());
    }
    IEnumerator sp()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(sceneToLoad);
    }
}