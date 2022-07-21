using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int _coins;

    public int Coins => _coins;

    private void Start()
    {
        _coins = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins++;
        }

        if ((collision.TryGetComponent<Enemy>(out Enemy enemy)) && _coins > 0)
        {
            _coins--;
        }
    }
}
