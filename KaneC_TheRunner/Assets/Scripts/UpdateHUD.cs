using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UpdateHUD : MonoBehaviour
{
    [Header("References")]
    public TMP_Text HUDTimer;
    public TMP_Text HUDDashes;
    public TMP_Text HUDJumps;

    [Header("Player Information")]
    private PlayerMovement pm;
    private Dashing dash;
    private float timer;

    private int minutes;
    private int seconds;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        pm = GetComponent<PlayerMovement>();
        dash = GetComponent<Dashing>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        minutes = Mathf.FloorToInt(timer / 60f);
        seconds = Mathf.FloorToInt(timer - minutes * 60);


        HUDDashes.text = "Dashes: " + dash.numberOfDashes;
        HUDJumps.text = "Jumps: " + pm.numJumps;
        HUDTimer.text = "Time: " + string.Format("{00:00}:{01:00}", minutes, seconds);
    }
}
