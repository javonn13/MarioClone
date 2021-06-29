using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll)
    {
        // Destroy the coin
        Destroy(gameObject);
    }
}