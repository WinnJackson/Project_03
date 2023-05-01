using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class _StatSet : MonoBehaviour
{
    // Start is called before the first frame update




    [SerializeField] private float _hp;
    [SerializeField] private float _attack;
    [SerializeField] private float _defense;

    public void setHP(float value) 
    {
        _hp = value;
    }

    public void setATK(float value)
    {
        _attack = value;
    }

    public void setDEF(float value)
    {
        _defense = value;
    }
}
