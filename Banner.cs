using UnityEngine;

public class BannerInteraction : MonoBehaviour
{
    public GameObject bannerCanvas; // Reference to the BannerCanvas

    private bool isPlayerNearby = false;

    void Start()
    {
        bannerCanvas.SetActive(false); // Ensure the canvas is hidden initially
    }

    void Update()
    {
        if (isPlayerNearby && Input.GetMouseButtonDown(1)) // Right-click to display text
        {
            bannerCanvas.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            bannerCanvas.SetActive(false); // Hide the canvas when the player moves away
        }
    }
}
