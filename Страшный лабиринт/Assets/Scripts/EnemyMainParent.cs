using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    [SerializeField] protected GameObject _scrimer;
    [SerializeField] protected GameObject _enemy;
    [SerializeField] protected GameObject _player;

    [SerializeField] protected int _deltaO2;

    [SerializeField] protected float _scrimerTime;
    [SerializeField] protected float _finalDistance;


    protected void MinesO2(int _deltaO2)
    {
        O2Controller.o2 -= _deltaO2;
    }

    protected IEnumerator ScrimerFright(float _scrimerTime, GameObject _scrimer)
    {
        _scrimer.SetActive(true);
        yield return new WaitForSeconds(_scrimerTime);
        _scrimer.SetActive(false);
    }

}
