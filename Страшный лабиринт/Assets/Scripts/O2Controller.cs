using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Controller : MonoBehaviour
{
    public static int o2 = 100;

    [SerializeField] private int _deltaO2;
    [SerializeField] private float _time;
    [SerializeField] private Text _textO2;

    void Start()
    {
        o2 = 100;
        StartCoroutine(MinesO2(_time, _deltaO2));
    }

    private void Update()
    {
        _textO2.text = o2 + "%"; 

        if(o2 < 1)
        {
            _textO2.text =  "0%";
            gameObject.GetComponent<DeathController>().life = false;
        }
    }

    public IEnumerator MinesO2(float _time, int _deltaO2)
    {
        while (o2 > 0)
        {
            yield return new WaitForSeconds(_time);
            o2 -= _deltaO2; 
        }
    }

}
