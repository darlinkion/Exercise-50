using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _firstPosition;
    [SerializeField] private Transform _secondPosition;

    Transform _targetPosition;

    private void Start()
    {
        _targetPosition = _firstPosition;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.position,_speed*Time.deltaTime);

        if (Vector3.Distance(transform.position, _firstPosition.position)<1f)
        {
            _targetPosition = _secondPosition;
        }
        else if(Vector3.Distance(transform.position, _secondPosition.position) < 0.5f)
        {
            _targetPosition = _firstPosition;
        }
    }
}
