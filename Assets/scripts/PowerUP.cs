using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    public float speedIncreaseAmount = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Controller_Player player = other.GetComponent<Controller_Player>();
            if (player != null)
            {
                player.IncreaseSpeed(speedIncreaseAmount);
                Destroy(gameObject);
            }
        }
    }
}
