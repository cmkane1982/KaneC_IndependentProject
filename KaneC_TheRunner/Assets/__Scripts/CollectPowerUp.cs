using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    [Header("References")]
    public GameObject go;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        go.GetComponentInParent<PlayerMovement>().CollectPowerup(layerMask);
    }
}
