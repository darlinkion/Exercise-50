using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Money))]

public class Wallet : MonoBehaviour
{
    [SerializeField] private Text _source;

    private Money _money;
    private int _coins;

    private void Start()
    {
        _money = GetComponent<Money>();
        _coins = _money.Coins;
        _source.text = "Sroce: " + _coins;
    }

    private void FixedUpdate()
    {
        _coins = _money.Coins;
        _source.text = "Sroce: " + _coins;
    }
}