using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour     //извин€юсь за говнокод :)
{
    public Text textNowScore;
    
    void Update()
    {
        textNowScore.text = "—чет: " + TouchController.score;
    }
}
                                                                  