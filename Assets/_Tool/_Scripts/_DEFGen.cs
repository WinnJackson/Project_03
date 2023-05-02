using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DEFGen : MonoBehaviour
{
    [SerializeField] public float _inputDEF = 5;

    public void AdjustATK(float value)
    {
        _inputDEF += value;
    }
}
