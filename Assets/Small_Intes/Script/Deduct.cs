using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduct : MonoBehaviour
{
    //public GameObject Boss;
    void OnCollisionEnter(Collision other)
    {
        print("A");
        if (other.gameObject == get_boss.Boss)
        {
            Deduct02.boss_hp -= 1;
            Destroy(gameObject);
            
        }
    }
}