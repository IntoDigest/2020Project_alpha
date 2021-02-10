using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    public GameObject keyhole;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == keyhole)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}