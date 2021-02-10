using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie : MonoBehaviour
{
    public GameObject sp;
    private Vector3 sp_pos;
    public float speed;
    void Start()
    {
        sp_pos = newer.sp_pos;
    }

    void Update()
    {
        Vector3 nowpos = transform.position;
        transform.position = Vector3.MoveTowards(nowpos, sp_pos, speed);
    }
}