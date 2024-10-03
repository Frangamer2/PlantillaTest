using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
    public float velocidad = 5f;
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform firePoint; // Punto desde donde se dispara el proyectil

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D o flechas izquierda/derecha
        float moveVertical = Input.GetAxis("Vertical"); // W/S o flechas arriba/abajo

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * velocidad * Time.deltaTime, Space.World);

        // Rotar al jugador en la dirección del movimiento
        if (movement != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 360 * Time.deltaTime);
        }
    }

    void Shoot()
    {
        // Crea el proyectil en la posición del firePoint
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Obtiene el Rigidbody del proyectil y aplica una fuerza
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * 500f); // Ajusta la fuerza según sea necesario
        }
    }
    public void IncreaseSpeed(float amount)
    {
        velocidad += amount;
    }
}
