using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FinishMenu : MonoBehaviour
{
    [Header("References")]
    public Canvas fm;
    public GameObject po;
    public GameObject sc;

    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        fm.enabled = false;
        po.transform.position = sc.transform.position;
        po.GetComponent<PlayerMovement>().numJumps = 0;
        po.GetComponent<Dashing>().numberOfDashes = 0;
        po.GetComponent<PlayerMovement>().timer = 0f;
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        EventSystem.current.SetSelectedGameObject(null);
    }
}
