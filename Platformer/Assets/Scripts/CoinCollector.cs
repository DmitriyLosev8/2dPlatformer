using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int _wallet;
    [SerializeField] private CoinsSpawner _spawnOfCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _wallet++;
            _spawnOfCoins.CurrentNumberOfCoins--;
            Destroy(collision.gameObject);
        }
    }
}
