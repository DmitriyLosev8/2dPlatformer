using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private List<GameObject> _bag = new List<GameObject>();
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _bag.Add(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
