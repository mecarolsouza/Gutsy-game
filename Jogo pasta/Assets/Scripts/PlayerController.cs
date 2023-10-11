using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject letterMedo;
    public GameObject RecadoPorta;
    private int currentEnergy = 50;
    private int maxEnergy = 100; // Defina o valor máximo de energia aqui.
    public Slider energySlider;
    private Animator animator;
    private bool correndo = false;
    private bool pulando = false;
  
    //double jump
    public bool isJumping;
    public bool doubleJump;

    private void Start()
    {
        RecadoPorta.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Atribuir o componente SpriteRenderer
        UpdateEnergy();
         currentEnergy = maxEnergy;
        animator = GetComponent<Animator>();
        energySlider = FindObjectOfType<Slider>(); // Encontre a barra de energia na cena
            // Se letterMedo for falso, ative o objeto RecadoPorta
     
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

                //Ativar animação de pulo
                pulando = true;
            }
         
         //Parar a animação de pulo
         if (rb.velocity.y == 0)
         {
            pulando = false;
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
        
         if (Input.GetAxis("Horizontal") != 0) // Verifique se a tecla de seta direita está pressionada
        {
            correndo = true;
        }
        else
        {
            correndo = false;
        }

        // Atualizando a variável "correndo" e "pulando" no Animator
        animator.SetBool("correndo", correndo);
        animator.SetBool("pulando", pulando);

        // Verifica se a tecla enter foi clicada ao chegar próximo a porta e carrega próxima cena
        if(Input.GetKeyDown(KeyCode.Return) && GameController.gControl.letterOn)
        {
            GameObject porta = GameObject.Find("Porta");
            Transform portaTransform = null;

            //teste para ver se a porta foi encontrada. Por algum motivo a condição só funciona com isso???? 
            if (porta != null)
            {
                portaTransform = porta.transform;
                Debug.Log("Porta encontrada!");
            }

            else
            {
                Debug.LogError("Porta não encontrada!");
            }

            if(porta != null){
                    // Verifique se o jogador está perto o suficiente da porta.
                    float distance = Vector3.Distance(transform.position, portaTransform.position);
                    
                    // Defina a distância mínima para permitir a passagem.
                    float distanciaMinima = 2.0f; // Ajuste conforme necessário.

                

                if (distance <= distanciaMinima){
                    // Desativa a função letterOn.
                    GameController.gControl.letterOn = false;
                    
                    SceneManager.LoadScene(GameController.gControl.proximaCena);

                }
            }            
            
            
        }

        // Diminuir a energia com base na velocidade de movimento (ajuste conforme necessário)
        int energyDecreaseAmount = Mathf.Abs((int)(rb.velocity.x * 0.1f));
        DecreaseEnergy(energyDecreaseAmount);
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
        // Certifica-se de que a energia não seja menor que zero
        currentEnergy = Mathf.Max(currentEnergy, 0);

        // Atualize a barra de energia
        if (energySlider != null)
        {
            energySlider.value = (float)currentEnergy / maxEnergy;
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

    //Detecta se o player colidiu com a porta e pressionou enter
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Porta") && GameController.gControl.letterOn)
        {
            //adicionar aqui a imagem de mensagem para pressionar enter
            //use nomeDoArquivo.SetActive(true)
        }
    }
    
    
}