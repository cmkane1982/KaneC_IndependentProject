using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    [Header("References")]
    public GameObject checkpoint;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = checkpoint.transform.position;
        player.GetComponent<PlayerMovement>().numJumps = 0;
        player.GetComponent<Dashing>().numberOfDashes = 0;
    }
}
