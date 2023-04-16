
using System;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform _prefab;

    private void Awake()
    {
        Instantiate(_prefab);
    }
}
