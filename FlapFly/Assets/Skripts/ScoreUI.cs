using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour     //��������� �� �������� :)
{
    public Text textNowScore;
    
    void Update()
    {
        textNowScore.text = "����: " + TouchController.score;
    }
}
                                                                  