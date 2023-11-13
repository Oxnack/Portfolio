using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TouchController : MonoBehaviour            //извин€юсь за говнокод :)
{
    public  GameObject explosion;
    private GameObject explosionClone;

    public float time1 = 1f;

    public Transform rocketTransform;

    public static int score;

                                    
    private void OnCollisionEnter2D(Collision2D thing)          
    {
        if (thing.gameObject.name == "Gas(Clone)")
        {
            score += 1;
            Destroy(thing.gameObject);
        }                                                                                                               
        else if (thing.gameObject.tag == "trash")
        {
            Destroy(thing.gameObject);

            explosionClone = Instantiate(explosion, new Vector3(rocketTransform.position.x, -1f, 0f), Quaternion.Euler(new Vector3(0,0,0)));

            TrashAppearance.defeatController = false;

            StartCoroutine(Destroer(time1, explosionClone));
        }
    }

    private IEnumerator Destroer(float time1, GameObject gameObject1)
    {
        yield return new WaitForSeconds(time1);
        Destroy(gameObject1);
    }

}
