using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Option_menu : MonoBehaviour
{
    public GameObject Option;
    public GameObject Menu;
    public void OnCollisionEnter(Collision collision)
    {
        Option.SetActive(true);
        Menu.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {     
    }
}
