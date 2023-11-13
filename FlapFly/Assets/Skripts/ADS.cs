using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour
{
    private bool ok = true;

    void Update()
    {
        if(ok == true && TrashAppearance.defeatController == false)
        {
           // ShowAd();
            ok = false;
        }
        else if(TrashAppearance.defeatController == true)
        {
            ok = true;
        }
    }

    public void ShowAd()
    {
       // Application.ExternalCall("ShowAd");
    }
}
