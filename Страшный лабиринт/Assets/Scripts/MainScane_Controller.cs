using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScane_Controller : MonoBehaviour
{
    [SerializeField] private GameObject _levelsMenu;
    [SerializeField] private GameObject _startButton;
    [SerializeField] private GameObject _smile;
    [SerializeField] private GameObject _lockLevel2, _lockLevel3;
    [SerializeField] private GameObject _wonMenu;

    [SerializeField] private float _timeSmile;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        //PlayerPrefs.SetInt("LevelUp", 0);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("LevelUp") == 1)              
        {
            _lockLevel2.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("LevelUp") == 2)
        {
            _lockLevel3.SetActive(false);
            _lockLevel2.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("LevelUp") == 3)
        {
            _wonMenu.SetActive(true);
        }
        else
        {
            _wonMenu.SetActive(false);
        }
    }


    public void LevelsMenu()
    {
        _levelsMenu.SetActive(true);
    }

    public void ToLevel1()
    {
        StartLevel("Level1");
    }

    public void ToLevel2()
    {
        if(PlayerPrefs.GetInt("LevelUp") > 0)
        {
            StartLevel("Level2");
        }
    }

    public void ToLevel3()
    {
        if (PlayerPrefs.GetInt("LevelUp") > 1)
        {
            StartLevel("Level3");
        }
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("LevelUp", 0);
    }

    private void StartLevel(string _nameScane)
    {
        _levelsMenu.SetActive(false);
        _startButton.SetActive(false);

        StartCoroutine(SlowActivator(_timeSmile, _smile, _nameScane));
    }

    private IEnumerator SlowActivator(float _time, GameObject _object, string _nameScane)
    {
        float _a = 0f;
        _object.SetActive(true);

        while (_a < 1f)
        {
            yield return new WaitForSeconds(_time);

            _object.GetComponent<Image>().color = new Color(1f, 1f, 1f, _a);

            _a += 0.01f;
        }

        SceneManager.LoadScene(_nameScane);
    }




}
