using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ATKGen : MonoBehaviour
{
    [SerializeField] public float _inputATK = 5;

    public void AdjustATK(float value)
    {
        _inputATK += value;
    }
}
