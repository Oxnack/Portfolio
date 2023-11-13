using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashAppearance : MonoBehaviour          //извин€юсь за говнокод :)
{
    public GameObject[] things = new GameObject[3];
    public GameObject canvas2;

    private int rand;
    private int randPositionX;

    public float time = 3f;

    public static bool defeatController;
    private bool ok = true;



    public void Restart()
    {
        defeatController = true;
        TouchController.score = 0;
    }


    void Start()
    {
        Debug.Log("It is good");
        defeatController = false;
    }

    private void Update()
    {
        if(defeatController == false)
        {
            canvas2.SetActive(true);
        }

        if(defeatController == true && ok == true)
        {
            StartCoroutine(Delay(time));
            ok = false;
        }
        else if(defeatController == false)
        {
            ok = true;
        }
    }

    private IEnumerator Delay(float time)
    {
        while (defeatController == true)
        {
            yield return new WaitForSeconds(time);
            CreateThings();
        }  
    }

    private IEnumerator Destroer(float time1, GameObject gameObject1)
    {
        yield return new WaitForSeconds(time1);
        Destroy(gameObject1);
    }

    private void CreateThings()
    {
        randPositionX = Random.Range(-8, 8);
        rand = Random.Range(0, 3);
        GameObject gameObject1;

        if (rand == 0)
        {
            gameObject1 = Instantiate(things[0], new Vector3(randPositionX, 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        else if (rand == 1)
        {
            gameObject1 = Instantiate(things[1], new Vector3(randPositionX, 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        else
        {
            gameObject1 = Instantiate(things[2], new Vector3(randPositionX, 10, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        }

        StartCoroutine(Destroer(5f, gameObject1));
    }


}
