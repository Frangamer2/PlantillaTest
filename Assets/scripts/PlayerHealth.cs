using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100; // Salud inicial

    public void TakeDamage(int damage)
    {
        health -= damage; // Reduce la salud por el da�o recibido
        Debug.Log("Salud restante: " + health);

        if (health <= 0)
        {
            Die(); // Llama a la funci�n de muerte si la salud llega a cero
        }
    }

    void Die()
    {
        Debug.Log("El jugador ha muerto.");
        // Aqu� puedes implementar la l�gica para manejar la muerte del jugador
        gameObject.SetActive(false); // Desactiva el objeto del jugador como ejemplo
    }
}
