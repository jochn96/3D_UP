using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadGround : MonoBehaviour
{
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCondition playerCondition = other.GetComponent<PlayerCondition>();
            if (playerCondition != null)
            {
                playerCondition.Die();
            }
        }
    }
}
