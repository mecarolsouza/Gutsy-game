using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public int energyAmount = 10; // Quantidade de energia que será concedida ao coletar o coletável

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.RechargeEnergy(energyAmount);
                Destroy(gameObject); // Destruir o coletável após coletar
            }
        }
    }

    
}
