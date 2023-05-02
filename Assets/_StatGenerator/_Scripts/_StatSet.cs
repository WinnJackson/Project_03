using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class _StatSet : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField] private float _constitution;
    [SerializeField] private _StatGen _recCON;

    [SerializeField] private float _strength;
    [SerializeField] private _StatGen _recSTR;

    [SerializeField] private float _agility;
    [SerializeField] private _StatGen _recAGI;

    [SerializeField] private float _intelligence;
    [SerializeField] private _StatGen _recINT;

    [SerializeField] private float _charisma;
    [SerializeField] private _StatGen _recCHR;

    [SerializeField] private float _luck;
    [SerializeField] private _StatGen _recLCK;


    public void setCON() 
    {
        _constitution = _recCON._inputStat;
        Debug.Log("Stat is set to " + _constitution);
    }
    public float GetCON() 
    {
        return _constitution;
    }


    public void setSTR()
    {
        _strength = _recSTR._inputStat;
        Debug.Log("Stat is set to " + _strength);
    }
    public float getSTR()
    {
        return _strength;
    }


    public void setAGI()
    {
        _agility = _recAGI._inputStat;
        Debug.Log("Stat is set to " + _agility);
    }
    public float getAGI()
    {
        return _agility;
    }


    public void setINT()
    {
        _intelligence = _recINT._inputStat;
        Debug.Log("Stat is set to " + _intelligence);
    }
    public float getINT() 
    {
        return _intelligence;
    }


    public void setCHR()
    {
        _charisma = _recCHR._inputStat;
        Debug.Log("Stat is set to " + _charisma);
    }
    public float getCHR()
    {
        return _charisma;
    }


    public void setLCK()
    {
        _luck = _recLCK._inputStat;
        Debug.Log("Stat is set to " + _luck);
    }
    public float getLCK()
    {
        return _luck;
    }
}
