using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]

public class Animation : MonoBehaviour
{
    private const string _speed = "Speed";

    private Animator _animator;
    private Movement _move;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _move = GetComponent<Movement>();
    }

    void Update()
    {
        _animator.SetFloat(_speed, Mathf.Abs(_move.DeltaX));
    }
}