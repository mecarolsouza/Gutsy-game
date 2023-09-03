using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do jogador

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public bool isJumping;
    public bool doubleJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Obter entrada do teclado para movimentar o jogador
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular a direção do movimento
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Normalizar a direção para que o jogador se mova com a mesma velocidade em todas as direções
        movement = movement.normalized;

        // Mover o jogador na direção calculada
        rb.velocity = movement * moveSpeed;

        // Verificar se o jogador está se movendo para a esquerda ou direita e aplicar o flip do sprite
        if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true; // Virar para a esquerda
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false; // Virar para a direita
        }
    }
   
}