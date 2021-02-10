using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quitgame : MonoBehaviour
{
    void Task()
    {
        Debug.Log("Exit!");
        Application.Quit();
    }
    void OnCollisionEnter(Collision other)
    {
        Task();
    }
}