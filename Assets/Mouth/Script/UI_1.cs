using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_1 : MonoBehaviour
{
    public GameObject hud;
    public static bool Bv = false;
    private bool mark = false;
    public static bool mk_1 = false;
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Bv == true && mark == false)
        {
            gameObject.SetActive(true);
            //StartCoroutine(ws());
            gameObject.SetActive(false);
            mark = true;
            mk_1 = true;
        }
    }

    IEnumerator ws()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            gameObject.SetActive(false);
            mark = true;
            mk_1 = true;
            break;
        }
    }
}