using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Coin _tempCoin;

    private void Start()
    {
        if (_points.Length == 0 || _tempCoin == null)
        {
            Debug.Log("No points or coin in script CoinSpawner");
        }
        else
        {
            for (int i = 0; i < _points.Length; i++)
            {
                Instantiate(_tempCoin, _points[i].transform.position, Quaternion.identity);
            }
        }
    }
}
