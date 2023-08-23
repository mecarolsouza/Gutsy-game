using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;      // Velocidade de movimento do jogador
    public float jumpForce;     // Força do pulo
   // public Transform groundCheck;    // Transform que verifica se o jogador está tocando o chão
   // public LayerMask groundLayer;    // Layer do chão para verificar colisão
    public SpriteRenderer spriteRenderer; // Referência para o componente SpriteRenderer
    private Rigidbody2D rb;
    //private bool isGrounded;
    //private bool canJump = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Atribuir o componente SpriteRenderer
    }

    private void Update()
    {
        // Verificar se o jogador está tocando o chão
        //isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Obter entrada do teclado para movimentar o jogador
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Calcular a direção do movimento
        Vector2 movement = new Vector2(moveHorizontal, 0f);

        // Normalizar a direção para que o jogador se mova com a mesma velocidade em todas as direções
        movement = movement.normalized;

        // Mover o jogador na direção calculada
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);

        // Verificar se o jogador está no chão e pode pular
         //if (isGrounded && canJump){}
        
            // Verificar se o jogador pressionou o botão de pulo (por exemplo, barra de espaço)
            if (Input.GetButtonDown("Jump"))
            {
                // Aplicar uma força para o pulo
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }

            // Flip do jogador
            if (movement.x < 0)
            {
                spriteRenderer.flipX = true; // Virar para a esquerda
            }
            else if (movement.x > 0)
            {
                spriteRenderer.flipX = false; // Virar para a direita
            }
        
    }
}
