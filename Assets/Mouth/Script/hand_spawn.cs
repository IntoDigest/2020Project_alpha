using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class hand_spawn : MonoBehaviour
{
    public SteamVR_Input_Sources Hand_type;
    public SteamVR_Action_Boolean Index_Finger;
    public GameObject Bullet;
    public GameObject hand_;
    public GameObject emp;
    private Vector3 now;
    public int cooldown;
    private float cdcnt = 0;
    void Update()
    {
        now = hand_.transform.position;

        if (Time.time > cdcnt)
        {
            if (Index_Finger.GetLastState(Hand_type))
            {
                cdcnt = Time.time + cooldown;
                Instantiate(Bullet, now, Quaternion.identity);
            }
        }
    }
}