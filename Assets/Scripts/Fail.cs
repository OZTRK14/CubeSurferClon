using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour
{
    public Animator Victory;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Collected"))
        {
           
            GameManager.instance.Fail = true;
            Victory.Play("Skateboarding 0", -1, 0);

        }

    }

}
