using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carrot : MonoBehaviour
{
    public GameObject w;
    public string nex;
    private Vector3 pos;
    void Start()
    {
        pos = gameObject.transform.position;
    }
    void Update()
    {
        if (pos != gameObject.transform.position)
        {
            SceneManager.LoadScene(nex);
        }
    }
}