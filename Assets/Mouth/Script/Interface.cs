﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(func());
    }

    IEnumerator func()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
            UI_1.Bv = true;
            Destroy(gameObject);
        }
    }
}