using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCamera : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public Vector3 offset; // Desplazamiento de la c�mara respecto al jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void LateUpdate()
    {
        // Calcula la posici�n deseada de la c�mara
        Vector3 desiredPosition = player.position + offset;
        // Suaviza la transici�n a la nueva posici�n
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Asigna la posici�n suavizada a la c�mara
        transform.position = smoothedPosition;

        // Opcional: Rotar la c�mara para mirar al jugador
        transform.LookAt(player);
    }
}
