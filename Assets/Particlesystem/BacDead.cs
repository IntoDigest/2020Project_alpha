using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacDead : MonoBehaviour
{
    public ParticleSystem deathParticle;
    private void OnCollisionEnter(Collision collision)
    {

        delete();
    }
    public void delete()
    {
        Instantiate(deathParticle);
        gameObject.SetActive(false);
    }
}
