using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
    public string Pre_Animated;
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Pre_Animated");
    }
}