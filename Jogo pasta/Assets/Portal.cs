using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter2D(Collider2D other);
    {
        // Verifica se o jogador colidiu com o objeto
        if (Letter medo.CompareTag("Player"))
        {
            // Desativa o objeto
            gameObject porta.SetActive(false);

            
        }
}
}