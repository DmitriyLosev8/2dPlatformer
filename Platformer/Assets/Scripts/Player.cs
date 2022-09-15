using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<GameObject> _bag = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))              
        {
            CollectCoins(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        ShowBag();
    }

    private void CollectCoins(GameObject coinToCollect)
    {
        _bag.Add(coinToCollect);
    }

    private void ShowBag()
    {  
        Debug.Log("Собранные монеты: " + _bag.Count);
    }
}
