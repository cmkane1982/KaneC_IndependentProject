using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuSystem : MonoBehaviour
{
    [Header("Input")]
    public KeyCode menuKey = KeyCode.Escape;

    [Header("References")]
    public Canvas pauseMenu;

    public bool inMenu = false;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            if (!inMenu)
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

            inMenu = !inMenu;
        }
    }

    public void ResumePlay()
    {
        Time.timeScale = 1f;
        pauseMenu.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        inMenu = false;
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
