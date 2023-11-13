using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour          //извин€юсь за говнокод :)
{
    public float speed        = 1f;
    public float asseleration = 0.1f;
    public float maxSpeed     = 5f;

    void Update()
    {
        if (TrashAppearance.defeatController == true)
        {
            gameObject.transform.position += speed * Time.deltaTime * new Vector3(0, -1, 0);
            speed += asseleration;  

            if (speed > maxSpeed)
            {
                asseleration = 0;
            }
        }
        else
        {
            asseleration = 0.1f;
        }
    }
}
