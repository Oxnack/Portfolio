using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FogController : MonoBehaviour
{
    [SerializeField] private GameObject _fog;
    [SerializeField] private float _maxFog;

    void Update()
    {
        _fog.GetComponent<Image>().color = new Color(0.3396226f, 0.3344962f, 0.3344962f, (Convert.ToSingle(101 - O2Controller.o2) / 100f) * _maxFog);


    }

}
