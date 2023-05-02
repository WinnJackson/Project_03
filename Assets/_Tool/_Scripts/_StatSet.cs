using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class _StatSet : MonoBehaviour
{
    // Start is called before the first frame update




    [SerializeField] private float _hp;
    [SerializeField] private _StatGen _recHP;

    [SerializeField] private float _attack;
    [SerializeField] private _StatGen _recATK;

    [SerializeField] private float _defense;
    [SerializeField] private _StatGen _recDEF;

    public void setHP() 
    {
        _hp = _recHP._inputStat;
        Debug.Log("Stat is set to " + _hp);
    }

    public void setATK()
    {
        _attack = _recATK._inputStat;
        Debug.Log("Stat is set to " + _attack);
    }

    public void setDEF()
    {
        _defense = _recDEF._inputStat;
        Debug.Log("Stat is set to " + _defense);
    }
}
