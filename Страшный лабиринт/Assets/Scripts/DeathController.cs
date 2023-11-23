using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathController : MonoBehaviour
{
    [SerializeField] private GameObject _deathImageText;
    [SerializeField] private GameObject _deathImage;
    [SerializeField] private GameObject _deathSound;

    [SerializeField] private GameObject[] _sounds = new GameObject[3];
    [SerializeField] private GameObject _camera;

    [SerializeField] private float _time;

    public bool life = true;
    private bool _ok = true;


    void Update()
    {
        if(life == false && _ok == true)
        {
            for (int i = 0; i < _sounds.Length; i++)
            {
                _sounds[i].SetActive(false);
            }

            gameObject.GetComponent<Player>().enabled = false;
            _camera.GetComponent<MouseLook>().enabled = false;

            _deathSound.SetActive(true);
            StartCoroutine(CutSceneDeath());
            _ok = false;
        }

    }


    private IEnumerator CutSceneDeath()
    {
        float _a = 0f;
        _deathImageText.SetActive(true);

        while (_a < 1f)
        {
            yield return new WaitForSeconds(_time);

            _deathImage.GetComponent<Image>().color = new Color(0f, 0f, 0f, _a);

            _a += 0.01f;
        }

        SceneManager.LoadScene("MainMenu");
    }

}
