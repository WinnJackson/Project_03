using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _StatGen : MonoBehaviour
{
    [SerializeField] public float _inputStat = 5;

    public void AdjustStat(float value)
    {
        if ((_inputStat + value) >= 1)
        {
            _inputStat += value;
        }
        else 
        {
            _inputStat = 1;
        }
    }
}
