using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    private Animator _animator;
    private Move _move;
    private string _speed;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _move = GetComponent<Move>();
        _speed = "Speed";
    }

    void Update()
    {
        _animator.SetFloat(_speed, Mathf.Abs(_move.DeltaX));

        if (!Mathf.Approximately(_move.DeltaX, 0))
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*Mathf.Sign(_move.DeltaX),transform.localScale.y,transform.localScale.z);
        }
    }
}