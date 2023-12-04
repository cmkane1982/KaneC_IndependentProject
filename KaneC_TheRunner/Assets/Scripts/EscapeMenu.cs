using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    [Header("Input")]
    public KeyCode menuKey = KeyCode.Escape;

    [Header("References")]
    public Canvas pauseMenu;

    public bool inMenu = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            inMenu = !inMenu;

            if (inMenu)
            {
                Time.timeScale = 0f;
                pauseMenu.enabled = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.enabled = false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
