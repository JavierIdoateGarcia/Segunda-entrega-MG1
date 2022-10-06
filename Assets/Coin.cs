using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinCount = 0;

    private void Start()
    {
        Coin.coinCount = Coin.coinCount + 1;
        Debug.Log("Empieza el juego" + Coin.coinCount + "Bolas");

    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Item") == true)
        {

        }

        Coin.coinCount--;
        Debug.Log("Recogida de moneda" + Coin.coinCount + "Bolas");

        if (Coin.coinCount == 0)
        {
            Debug.Log("El juego termino");

        }

        Destroy(gameObject);
    }





   
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
