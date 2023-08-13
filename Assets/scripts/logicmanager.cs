using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class logicmanager : MonoBehaviour
{
    public GameObject cat;
    public GameObject mouse;
    public Canvas canvas;
    public Canvas mainmenucanvas;
    public FixedJoystick joystick;
    public GameObject pausebutton;
    public GameObject levelupbutton;
    public Canvas pausemenu;
    public GameObject levelupbuttontext;
    public GameObject mousespawner;
    public GameObject healthbar;
    public void StartGame()
    {
        Actions.startaction();
        cat.SetActive(true);
        mouse.SetActive(true);
        canvas.gameObject.SetActive(true);
        mainmenucanvas.gameObject.SetActive(false);
        joystick.gameObject.SetActive(true);
        pausebutton.SetActive(true);
        levelupbutton.gameObject.SetActive(true);
        mousespawner.SetActive(true);
        healthbar.SetActive(true);
    }
    public void PauseGame()
    {
        pausemenu.gameObject.SetActive(true);
        canvas.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pausemenu.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        Time.timeScale = 1f;
    }
    
   
}
