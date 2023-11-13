using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinController : MonoBehaviour
{
    public GameObject win;
    public float timeToDesActive = 1f;
    private bool ok = true;

    void Update()
    {
        if(ok == true && TouchController.score == 500)
        {
            TrashAppearance.defeatController = false;

            win.SetActive(true);

            StartCoroutine(DesActive(timeToDesActive, win));

            ok = false;
        }
    }

    private IEnumerator DesActive(float time1, GameObject gameObject1)
    {
        yield return new WaitForSeconds(time1);

        gameObject1.SetActive(false);

        TrashAppearance.defeatController = true;
        TouchController.score = 500;
    }
}
