using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Animation))]

public class Animation : MonoBehaviour
{
    private const string Speed = "Speed";

    private Animator _animator;
    private Movement _move;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _move = GetComponent<Movement>();
    }

    private void Update()
    {
        _animator.SetFloat(Speed, Mathf.Abs(_move.DeltaX));
    }
}