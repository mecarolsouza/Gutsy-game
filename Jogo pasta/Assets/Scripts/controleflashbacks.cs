using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleFlashbacks : MonoBehaviour
{
    public GameObject imagem1;
    public GameObject imagem2;
    public GameObject imagem3;
    
    private int estado = 0; // 0: imagem1, 1: imagem2, 2: imagem3
    private bool cenaAtivada = false;

    // Start is called before the first frame update
    void Start()
    {
        AtualizarImagens();
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se o botão de espaço foi pressionado
        if (Input.GetKeyDown(KeyCode.Space))
        {
            estado++;
            if (estado > 2)
            {
                cenaAtivada = true;
            }
            AtualizarImagens();
        }

        // Ativa a cena Nivel1 quando necessário
        if (cenaAtivada)
        {
            SceneManager.LoadScene("Nível1");
        }
    }

    // Atualiza o estado das imagens de acordo com o valor de 'estado'
    void AtualizarImagens()
    {
        imagem1.SetActive(estado == 0);
        imagem2.SetActive(estado == 1);
        imagem3.SetActive(estado == 2);
    }
}
