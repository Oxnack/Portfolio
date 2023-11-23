using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMain : MonoBehaviour
{
    [SerializeField] protected GameObject _scrimer;
    [SerializeField] protected GameObject _enemy;
    [SerializeField] protected GameObject _player;
    [SerializeField] protected Text _dialog;

    [SerializeField] protected int _deltaO2;

    [SerializeField] protected float _scrimerTime;
    [SerializeField] protected float _finalDistance;
    [SerializeField] protected float _enemySpeed;


    protected void MinesO2(int deltaO2)
    {
        O2Controller.o2 -= deltaO2;
    }

    protected IEnumerator ScrimerFright(float scrimerTime, GameObject scrimer, GameObject screamSound)
    {
        scrimer.SetActive(true);
        yield return new WaitForSeconds(scrimerTime);
        scrimer.SetActive(false);
        screamSound.SetActive(false);
    }

}
