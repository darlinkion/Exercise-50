using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private GameObject _gameObject; 

    void Start()
    {
        if (_points.Length == 0 || _gameObject == null)
        {
            Debug.Log("No points or coin in script CoinSpawner");
        }
        else
        {
            for(int i = 0; i < _points.Length; i++)
            {
               Instantiate(_gameObject, _points[i].transform.position, Quaternion.identity);
            }
        }
    }
}
