using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public float speed = 3f; // Velocidad del enemigo
    public float attackRange = 1.5f; // Rango de ataque
    public int damage = 10; // Daño que causa el enemigo

    private void Update()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        // Verifica si hay una referencia al jugador
        if (player != null)
        {
            // Calcula la dirección hacia el jugador
            Vector3 direction = (player.position - transform.position).normalized;

            // Mueve al enemigo hacia el jugador
            transform.position += direction * speed * Time.deltaTime;

            // Verifica si está en rango de ataque
            if (Vector3.Distance(transform.position, player.position) <= attackRange)
            {
                AttackPlayer();
            }
        }
    }

    void AttackPlayer()
    {
        // Aquí puedes implementar la lógica para causar daño al jugador
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
    }
}
