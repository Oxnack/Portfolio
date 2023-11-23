using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Tith : EnemyMain
{
    [SerializeField] private GameObject _scrimeTithSound;

    private bool _ok = true;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Good work");

        if (other.gameObject.tag == "Player" && _ok == true)
        {
            _scrimeTithSound.SetActive(true);

            StartCoroutine(ScrimerFright(_scrimerTime, _scrimer, _scrimeTithSound));
            O2Controller.o2 -= 20;

            _ok = false;
        }
    }

 

}
