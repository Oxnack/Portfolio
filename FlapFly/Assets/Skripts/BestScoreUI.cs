using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreUI : MonoBehaviour       //извин€юсь за говнокод :)
{
    public Text textBestScore;

    public static int bestScore;

    public GameObject canvas2;



    void Update()
    {
        if (TrashAppearance.defeatController == true)
        {
            canvas2.SetActive(false);
        }

        if (TouchController.score > PlayerPrefs.GetInt("bestScore"))
        {
            bestScore = TouchController.score;
            PlayerPrefs.SetInt("bestScore", bestScore);
        }
        textBestScore.text = "Ћучший счет: " + PlayerPrefs.GetInt("bestScore");
    }
}
