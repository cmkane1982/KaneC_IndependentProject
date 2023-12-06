using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Information : MonoBehaviour
{
    private bool inMenu;

    // Start is called before the first frame update
    void Start()
    {
        inMenu = true;
    }

    private void Update()
    {
        if (inMenu)
        {
            Time.timeScale = 0f;
            this.GetComponent<Canvas>().enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void CloseInformation()
    {
        Time.timeScale = 1f;
        this.GetComponent<Canvas>().enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        EventSystem.current.SetSelectedGameObject(null);
        inMenu = false;
    }
}
