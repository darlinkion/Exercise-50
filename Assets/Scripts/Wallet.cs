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
            Debug.Log("В кошельке " + _coins + " монет");
        }

        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            if (_coins > 0)
            {
                _coins--;
                Debug.Log("Моб забрал монету, в кошельке осталось " + _coins + " монет");
            }
            else
            {
                Debug.Log("Мобу у Вас даже забрать нечего, у вас 0 монет");
            }
        }
    }
}
