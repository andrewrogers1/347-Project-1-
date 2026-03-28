using UnityEngine;

public class ColorChangePlatform : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color steppedOnColor = Color.red; // Color when stepped on
    private Color originalColor; // To store the original color

    void Start()
    {
        // Get the SpriteRenderer component attached to the platform
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Store the platform's original color
        originalColor = spriteRenderer.color;
    }

    // Called when another collider enters the platform's collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object that collided with the platform is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Change the platform's color
            spriteRenderer.color = steppedOnColor;
        }
    }

    // Called when the other collider stops touching the platform's collider
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the object leaving the platform is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Revert to the original color
            spriteRenderer.color = originalColor;
        }
    }
}
