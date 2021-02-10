using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deduct02 : MonoBehaviour
{
    public int MxHealth;
    public static int boss_hp; //ไม่ต้องสนใจ

    void Start()
    {
        boss_hp = MxHealth;
    }

    void Update()
    {
        if (boss_hp < 0)
        {
            //GameOver
            print("A");
        }
    }
}