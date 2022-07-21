using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _firstPosition;
    [SerializeField] private Transform _secondPosition;
    [SerializeField] private float _deltaPosition;

    Transform _targetPosition;

    private void Start()
    {
        _targetPosition = _firstPosition;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.position, _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _firstPosition.position) < _deltaPosition)
        {
            _targetPosition = _secondPosition;
        }
        else if (Vector3.Distance(transform.position, _secondPosition.position) < _deltaPosition)
        {
            _targetPosition = _firstPosition;
        }
    }
}