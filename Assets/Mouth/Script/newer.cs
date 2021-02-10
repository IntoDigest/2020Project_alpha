using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class newer : MonoBehaviour
{
    public GameObject sp;

    static public Vector3 sp_pos;
    void Update()
    {
        sp_pos = sp.transform.position;
    }
}