using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed;      // Velocidade de movimento do jogador
    public float jumpForce;     // Força do pulo
   // public Transform groundCheck;    // Transform que verifica se o jogador está tocando o chão
   // public LayerMask groundLayer;    // Layer do chão para verificar colisão
    public SpriteRenderer spriteRenderer; // Referência para o componente SpriteRenderer
    private Rigidbody2D rb;
    private bool isGrounded;
    private bool canJump = true; 
    public GameObject Battery;
    private int currentEnergy = 50;
    private int maxEnergy = 100; // Defina o valor máximo de energia aqui.
    private float energyDecreaseRate = 1.0f;
    private float energyDecreaseTimer = 0.0f;
    public Slider energySlider;
    private Animator animator;
    private bool correndo = false;

    //double jump
    public bool isJumping;
    public bool doubleJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Atribuir o componente SpriteRenderer
        UpdateEnergy();
        animator = GetComponent<Animator>();
    }

    

    public void Update()
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
         if (isGrounded && canJump){}
        
            // Verificar se o jogador pressionou o botão de pulo (por exemplo, barra de espaço)
            if (Input.GetButtonDown("Jump") && !isJumping)
            {
                // Aplicar uma força para o pulo
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }

            // Flip do jogador
            if (movement.x < 0)
            {
                spriteRenderer.flipX = false; // Virar para a esquerda
            }
            else if (movement.x > 0)
            {
                spriteRenderer.flipX = true; // Virar para a direita
            }
        
         if (Input.GetKey(KeyCode.RightArrow)) // Verifique se a tecla de seta direita está pressionada
        {
            correndo = true;
        }
        else
        {
            correndo = false;
        }

        // Atualize a variável "correndo" no Animator
        animator.SetBool("correndo", correndo);
    }
    
    //double jump e limite de pulo
            void OnCollisionEnter2D(Collision2D collision)
            {
                if(collision.gameObject.layer == 7){
                    isJumping = false;

                }
            }
            void OnCollisionExit2D(Collision2D collision)
            {
                if(collision.gameObject.layer == 7){
                    isJumping = true;
                }
            }
             
        private void UpdateEnergy()
    {
        // Diminui a energia com o tempo
        energyDecreaseTimer += Time.deltaTime;
        if (energyDecreaseTimer >= 1.0f) // Diminui a energia a cada segundo
        {
            energyDecreaseTimer = 0.0f;
            DecreaseEnergy(1); // Diminui a energia em 1 unidade a cada segundo
        }
    }
       public void RechargeEnergy(int amount)
    {
        // Recarrega a energia
        currentEnergy += amount;
        // Certifica-se de que a energia não exceda o valor máximo
        currentEnergy = Mathf.Clamp(currentEnergy, 0, maxEnergy);
        // Atualiza o valor do slider de energia
        energySlider.value = (float)currentEnergy / maxEnergy;
    }
       public void DecreaseEnergy(int amount)
    {
        // Diminui a energia
        currentEnergy -= amount;
        // Certifica-se de que a energia não fique abaixo de 0
        currentEnergy = Mathf.Max(currentEnergy, 0);
       // Atualiza o valor do slider de energia
        energySlider.value = (float)currentEnergy / 100f;
    }

}