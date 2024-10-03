using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float xLimit = 30;
    public float yLimit = 20;
    
    virtual public void Update()
    {
        CheckLimits();
    }

    internal virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") )
        {
            Destroy(this.gameObject);
        }
    }
    //
    internal virtual void CheckLimits()
    {
        if (this.transform.position.x > xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.x < -xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.y > yLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.y < -yLimit)
        {
            Destroy(this.gameObject);
        }

    }

    public int damage = 10; // Daño del proyectil

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")) // Asegúrate de que el enemigo tenga el tag "Enemy"
        {
            Enemigo enemy = other.GetComponent<Enemigo>(); // Obtén el componente del enemigo
            if (enemy != null)
            {
                enemy.TakeDamage(damage); // Llama al método para causar daño
            }
            Destroy(gameObject); // Destruye el proyectil después de impactar
        }

        Debug.Log("Colisión con: " + other.name); // Verifica con qué objeto está colisionando
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Impacto en enemigo: " + other.name);
            Enemigo enemy = other.GetComponent<Enemigo>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Debug.Log("Daño causado: " + damage);
            }
            Destroy(gameObject);
        }
    }

}
