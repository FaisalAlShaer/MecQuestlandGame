using UnityEngine;
using System.Collections;

public class TutorialController : MonoBehaviour
{
    public GameObject tutorialCanvas; // Reference to the Tutorial Canvas
    public float displayTime = 10f; // Time to display the tutorial

    private bool hasShown = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasShown)
        {
            StartCoroutine(ShowTutorial());
        }
    }

    private IEnumerator ShowTutorial()
    {
        hasShown = true; // Ensure it only shows once
        tutorialCanvas.SetActive(true);
        yield return new WaitForSeconds(displayTime);
        tutorialCanvas.SetActive(false);
        gameObject.SetActive(false); // Disable the trigger after use
    }
}
