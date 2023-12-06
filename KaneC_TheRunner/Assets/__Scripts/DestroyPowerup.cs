using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerup : MonoBehaviour
{
    [Header("References")]
    public GameObject powerup;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(powerup);
    }
}
