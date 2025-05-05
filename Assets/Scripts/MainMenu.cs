using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject savesPanel;
    public GameObject contactFormPanel;
    public GameObject newGamePanel;
    public Button buttonStart;
    public Button buttonQuit;

    void Awake()
    {
        optionsPanel.SetActive(false);
        savesPanel.SetActive(false);
        contactFormPanel.SetActive(false);
        newGamePanel.SetActive(false);
    }

    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void ToggleOptionsPanel()
    {
        if (optionsPanel.activeSelf == true)
        {
            optionsPanel.SetActive(false);
            buttonStart.enabled = true;
            buttonQuit.enabled = true;
        }
        else
        {
            optionsPanel.SetActive(true);
            buttonStart.enabled = false;
            buttonQuit.enabled = false;
        }
    }
    public void ToggleSavesPanel()
    {
        if (savesPanel.activeSelf == true)
        {
            savesPanel.SetActive(false);
            buttonStart.enabled = true;
            buttonQuit.enabled = true;
        }
        else
        {
            savesPanel.SetActive(true);
            buttonStart.enabled = false;
            buttonQuit.enabled = false;
        }
    }
    public void ToggleContactFormPanel()
    {
        if (contactFormPanel.activeSelf == true)
        {
            contactFormPanel.SetActive(false);
            buttonStart.enabled = true;
            buttonQuit.enabled = true;
        }
        else
        {
            contactFormPanel.SetActive(true);
            buttonStart.enabled = false;
            buttonQuit.enabled = false;
        }
    }
    public void ToggleNewGamePanel()
    {
        if (newGamePanel.activeSelf == true)
        {
            newGamePanel.SetActive(false);
            buttonStart.enabled = true;
            buttonQuit.enabled = true;
        }
        else
        {
            newGamePanel.SetActive(true);
            buttonStart.enabled = false;
            buttonQuit.enabled = false;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
