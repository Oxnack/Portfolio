using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinController : MonoBehaviour
{
    [SerializeField] private GameObject _winSmile;
    [SerializeField] private GameObject _camera;

    [SerializeField] private GameObject _textAfraid;
    [SerializeField] private GameObject[] _sounds = new GameObject[3];
    [SerializeField] private float _timeSpeed;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision ok");

        if (other.gameObject.tag == "Finish")
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                if (PlayerPrefs.GetInt("LevelUp") < 1)
                {
                    PlayerPrefs.SetInt("LevelUp", 1);
                }
            }
            else if(SceneManager.GetActiveScene().name == "Level2")
            {
                PlayerPrefs.SetInt("LevelUp", 2);
            }
            else
            {
                PlayerPrefs.SetInt("LevelUp", 3);
            }

            gameObject.GetComponent<Player>().enabled = false;
            _camera.GetComponent<MouseLook>().enabled = false;

            for (int i = 0; i < _sounds.Length; i++)
            {
                _sounds[i].SetActive(false);
            }

            O2Controller.o2 = 1000;
            _winSmile.SetActive(true);
            StartCoroutine(SlowActivator(_timeSpeed, _textAfraid, "MainMenu"));
        }
    }

    private IEnumerator SlowActivator(float _time, GameObject _object, string _nameScane)
    {
        float _a = 0f;
        _object.SetActive(true);

        yield return new WaitForSeconds(2f);

        while (_a < 1f)
        {
            yield return new WaitForSeconds(_time);

            _object.GetComponent<Text>().color = new Color(0.735849f, 0.08608042f, 0.08608042f, _a);

            _a += 0.01f;
        }
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(_nameScane);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
