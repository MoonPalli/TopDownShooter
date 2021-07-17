using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDirection : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector2 _me;

    private void Awake()
    {
        _me = transform.position;
        Vector2 _targetPos = _target.transform.position;

        Debug.Log($"{_me} | {_targetPos}");
        Debug.Log($"Direction between: {_me - _targetPos}.");
    }
}