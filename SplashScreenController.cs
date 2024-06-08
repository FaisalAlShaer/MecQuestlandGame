using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{
    public float displayTime = 5f; // Duration the splash screen is shown

    void Start()
    {
        StartCoroutine(ShowSplashScreen());
    }

    IEnumerator ShowSplashScreen()
    {
        yield return new WaitForSeconds(displayTime);
        SceneManager.LoadScene("Main Menu"); // Replace "MainMenu" with the name of your main menu scene
    }
}
