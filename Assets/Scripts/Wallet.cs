using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _coins;

    private void Start()
    {
        _coins = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins++;
            Debug.Log("� �������� " + _coins + " �����");
        }

        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            if (_coins > 0)
            {
                _coins--;
                Debug.Log("��� ������ ������, � �������� �������� " + _coins + " �����");
            }
            else
            {
                Debug.Log("���� � ��� ���� ������� ������, � ��� 0 �����");
            }
        }
    }
}
