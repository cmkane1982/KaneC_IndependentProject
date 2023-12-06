using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishLevel : MonoBehaviour
{
    [Header("References")]
    public Canvas finishCanvas;
    public TMP_Text timeText;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        finishCanvas.enabled = true;
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        PlayerMovement pm = player.GetComponent<PlayerMovement>();

        int minutes = Mathf.FloorToInt(pm.timer / 60f);
        int seconds = Mathf.FloorToInt(pm.timer - minutes * 60);

        timeText.text = "Your Time: " + string.Format("{00:00}:{01:00}", minutes, seconds);
    }

    private void OnTriggerExit(Collider other)
    {
        finishCanvas.enabled = false;
    }
}
