using UnityEngine;

public class MostrarOcultarObjeto : MonoBehaviour
{
   public GameObject tutorialmovimento;
    private void Start()
    {
        // No início, o GameObject é visível
        tutorialmovimento.SetActive(true);
    }

    private void Update()
    {
        // Verifica se o jogador pressionou as setas "A" ou "D"
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal != 0)
        {
            // Se o jogador pressionou qualquer uma das setas, oculta o GameObject
            tutorialmovimento.SetActive(false);
        }
    }
}

