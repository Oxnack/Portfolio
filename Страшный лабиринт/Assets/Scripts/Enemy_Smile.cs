using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Smile : EnemyMain
{

    void Update()
    {
        float _distance = Vector3.Distance(_player.transform.position, transform.position);

        transform.LookAt(_player.transform);

        if (_distance < _finalDistance)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
