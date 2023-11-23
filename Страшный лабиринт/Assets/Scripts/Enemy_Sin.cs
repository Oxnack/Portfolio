using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sin : EnemyMain
{
    [SerializeField] private float _z;
    [SerializeField] private float _x;
    [SerializeField] private float _time;

    private void Start()
    {
        StartCoroutine(Blink());
    }

    private void Update()
    {
        transform.position += new Vector3(Mathf.Sin(Time.time) * _enemySpeed * _x, 0, Mathf.Sin(Time.time) * _enemySpeed * _z);

        transform.LookAt(_player.transform);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MinesO2(100);

            _dialog.text = "Вас убил призрак, в следующий раз будьте аккуратнее!";
        }
    }

    private IEnumerator Blink()
    {
        while (true)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(_time);
            gameObject.GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(_time);
        }
    }

}
