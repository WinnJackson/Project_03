using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _HPGen : MonoBehaviour
{
    [SerializeField] public float _inputHP = 5;

    public void AdjustHP(float value)
    {
        if ((_inputHP + value) >= 1)
        {
            _inputHP += value;
        }
        else 
        {
            _inputHP = 1;
        }
    }
}
