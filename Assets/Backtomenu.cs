using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomenu : MonoBehaviour
{
    public int TimetoBack;
    void Start()
    {
        StartCoroutine(wait_spawn());
    }

    IEnumerator wait_spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimetoBack);
            SceneManager.LoadScene("Menu");
        }
    }
}

