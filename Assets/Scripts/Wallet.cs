using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Text _source;

    private int _coins;

    private void Start()
    {
        _coins = 0;
        _source.text = "Sroce: " + _coins;
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

        _source.text = "Sroce: " + _coins;
    }
}