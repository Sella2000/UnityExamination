using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coinCollider2D)
    {
        if (coinCollider2D.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }    
    }
}
