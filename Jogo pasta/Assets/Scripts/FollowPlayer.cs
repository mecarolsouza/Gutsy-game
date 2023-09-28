using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Referência ao transform do jogador que a câmera deve seguir
    public float smoothSpeed = 0.125f; // Velocidade de interpolação suave

    private Vector3 offset; // O deslocamento inicial entre a câmera e o jogador

    private void Start()
    {
        offset = transform.position - target.position; // Calcula o deslocamento inicial
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    
}

