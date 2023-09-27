using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //private Vector3 offset new Vector3(0f, 0f, -10f);
    [SerializeField] private Transform player;
    public float smoothSpeed = 0.25f;
    
    public float minX, maxX;
    public float minY, maxY;
    
    void Start()
    {
       // Verifique se o jogador está atribuído.
        /*if (player != null)
        {
            // Defina a posição inicial da câmera para a posição inicial do jogador.
            Vector3 initialPosition = player.position + new Vector3(0, 0, -10);
            initialPosition.y = Mathf.Clamp(initialPosition.y, minY, maxY);
            transform.position = initialPosition;
        }
        else
        {
            Debug.LogError("O jogador não está atribuído ao script da câmera.");
        }*/
    }

    /*void LateUpdate()
    {
        // Verifique se o personagem alvo existe.
        if (player != null)
        {
            // Calcule a posição desejada da câmera com base na posição do personagem e no offset.
            Vector3 newPosition = player.position;

            // Aplique limites X e Y à posição desejada.
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
            newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

            // Interpole suavemente a posição atual da câmera em direção à posição desejada.
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, newPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }*/

    private void FixedUpdate()
    {
        Vector3 newPosition = player.position + new Vector3 (0,0,-10);
        //newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        //transform.position = newPosition;

        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;

        
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x,minX,maxX), Mathf.Clamp(transform.position.y,minY,maxX), transform.position.z);
    }


}
