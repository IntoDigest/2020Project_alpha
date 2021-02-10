using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class Laser : MonoBehaviour
{
    //public GameObject laser;
    public SteamVR_Input_Sources Hand_Type;
    public SteamVR_Action_Boolean Finger;
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Finger.GetLastState(Hand_Type))
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
