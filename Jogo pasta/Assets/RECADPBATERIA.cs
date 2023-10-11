using UnityEngine;

public class RecadoBateriaCONTROLLER : MonoBehaviour
{
    public GameObject RecadoBateria;
    
    private void Start()
    {
        // Comece com o objeto desativado
        RecadoBateria.SetActive(true);
    }

    private void Update()
    {
        // Verifique se o botão de espaço foi pressionado
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Ative o objeto RecadoBateria
            RecadoBateria.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifique se o jogador colidiu com uma bateria
        if (other.CompareTag("Battery"))
        {
            // Desative o objeto RecadoBateria
            RecadoBateria.SetActive(false);
        }
    }
}

