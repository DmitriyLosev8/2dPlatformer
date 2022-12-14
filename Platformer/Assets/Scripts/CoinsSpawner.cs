using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private int _maxNumberOfCoins;

    public int CurrentNumberOfCoins;

    private void Start()
    {
        CreateCoins();
    }

    private void Update()
    {
        if (CurrentNumberOfCoins < _maxNumberOfCoins)
        {
            CreateCoins();
        }
    }

    private void CreateCoins()
    {
        float leftBorderOfSpawn = -18;
        float rightBorderOfSpawn = 17;
        float topBorderOfSpawn = -4;
        float bottomBorderOfSpawn = -7.5f;

        while (CurrentNumberOfCoins < _maxNumberOfCoins)
        {
            float coordinateX = Random.Range(leftBorderOfSpawn, rightBorderOfSpawn);
            float coordinateY = Random.Range(topBorderOfSpawn, bottomBorderOfSpawn);
            float coordinateZ = 0;

            Coin newCoin = Instantiate(_coin, new Vector3(coordinateX, coordinateY, coordinateZ), Quaternion.identity);
            CurrentNumberOfCoins++;  
        }
    }
}
