using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _HPGen : MonoBehaviour
{
    [SerializeField] public float _inputHP = 5;

    public void AdjustHP(float value)
    {
        _inputHP += value;
    }
}
