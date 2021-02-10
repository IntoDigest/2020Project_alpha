using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Waittime : MonoBehaviour
{
    //public List <GameObject> Items;

    // Start is called before the first frame update
    public int Timing;
    void Start()
    {
        StartCoroutine(wait_spawn());
    }

    IEnumerator wait_spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Timing);
            SceneManager.LoadScene("Pre_animated");
        }
    }
}