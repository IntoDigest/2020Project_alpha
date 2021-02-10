using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class now : MonoBehaviour
{
    public GameObject player_;

    static public Vector3 player;
    void Update()
    {
        player = player_.transform.position;
    }
}