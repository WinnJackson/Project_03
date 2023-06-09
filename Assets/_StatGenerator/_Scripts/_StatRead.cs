using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _StatRead : MonoBehaviour
{
    [SerializeField] private _StatGen _stat;
    [SerializeField] private float _statToRead;
    [SerializeField] TextMeshProUGUI _statTextToView;


    private void Update()
    {
        if (_stat != null)
        {
            _statToRead = _stat._inputStat;
        }

        _statTextToView.text = _statToRead.ToString();
    }


}
