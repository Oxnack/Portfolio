using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour        //извин€юсь за говнокод :)
{
    public float speedX = 20f;
    private bool rightController = false;      
    private bool leftController = false;

    void Start()                                       
    {
        Debug.Log("Hello World");
    }

    public void Left()
    {
        leftController = true;
    }
    public void NotLeft()
    {
        leftController = false;
    }



    public void Right()
    {
        rightController = true;
    }
    public void NotRight()
    {
        rightController = false;
    }



    void Update()
    {

        if (TrashAppearance.defeatController == true)
        {
            if (leftController == true)
            {
                transform.position += speedX * Time.deltaTime * new Vector3(-1, 0, 0);
            }
            else if (rightController == true)
            {
                transform.position += speedX * Time.deltaTime * new Vector3(1, 0, 0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D thing)
    {
        if (thing.gameObject.name == "Square(1)")
        {
            transform.position = new Vector3(-8.0f, -2.82f, 0f);
        }
        else if(thing.gameObject.name == "Square")
        {
            transform.position = new Vector3(8.0f, -2.82f, 0f);
        }
    }
}
