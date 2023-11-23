using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Nexbot : EnemyMain
{


    private void FixedUpdate()
    { 
        transform.LookAt(_player.transform);

        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _enemySpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _scrimer.SetActive(true);
            O2Controller.o2 -= 100;
        }
    }
}
