using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject aboutUsPanel; // Reference to the About Us panel
    public GameObject controlsPanel; // Reference to the Controls panel

    public void PlayGame()
    {
        // Replace "ParkingLotLevel" with the name of the scene you want to load
        SceneManager.LoadScene("ParkingLotLevel");
    }

    public void AboutUs()
    {
        aboutUsPanel.SetActive(true);
        controlsPanel.SetActive(false); // Hide other panels if needed
    }

    public void Controls()
    {
        controlsPanel.SetActive(true);
        aboutUsPanel.SetActive(false); // Hide other panels if needed
    }

    public void CloseAboutUs()
    {
        aboutUsPanel.SetActive(false);
    }

    public void CloseControls()
    {
        controlsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
