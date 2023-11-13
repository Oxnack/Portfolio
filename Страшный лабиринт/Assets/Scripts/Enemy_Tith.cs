using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tith : EnemyMain
{
    private bool _ok = true;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Good work");

        if (other.gameObject.tag == "Player" && _ok == true)
        {
            StartCoroutine(ScrimerFright(_scrimerTime, _scrimer));

            _ok = false;
        }
    }

 

}
