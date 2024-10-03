using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCamera : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public Vector3 offset; // Desplazamiento de la cámara respecto al jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void LateUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = player.position + offset;
        // Suaviza la transición a la nueva posición
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Asigna la posición suavizada a la cámara
        transform.position = smoothedPosition;

        // Opcional: Rotar la cámara para mirar al jugador
        transform.LookAt(player);
    }
}
