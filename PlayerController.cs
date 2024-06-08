using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    public GameObject bookCanvas; // Reference to the BookCanvas
    public GameObject tutorialCanvas;

    Vector2 movementInput;
    Rigidbody2D rb;
    Animator animator;
    List<RaycastHit2D> castCollision = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        // Check if the bookCanvas is active
        if ((bookCanvas != null && bookCanvas.activeSelf) || (tutorialCanvas != null && tutorialCanvas.activeSelf))
        {
            movementInput = Vector2.zero; // Stop player movement
        }

        // If movement input is not 0, try to move
        bool success = false;
        if (movementInput != Vector2.zero)
        {
            success = TryMove(movementInput);

            if (!success)
            {
                success = TryMove(new Vector2(movementInput.x, 0));

                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }
            }
        }

        animator.SetBool("IsMoving", success);
    }

    private bool TryMove(Vector2 direction)
    {
        int count = rb.Cast(
            direction,
            movementFilter,
            castCollision,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);

        if (count == 0)
        {
            rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
            return true;
        }
        else
        {
            return false;
        }
    }

    void OnMove(InputValue movementValue)
    {
        if (bookCanvas != null && bookCanvas.activeSelf)
        {
            movementInput = Vector2.zero; // Stop player movement
        }
        else
        {
            movementInput = movementValue.Get<Vector2>();

            // Updating the animation parameters - 20F20646 Faisal Al Shaer
            animator.SetFloat("XInput", movementInput.x);
            animator.SetFloat("YInput", movementInput.y);
        }
    }
}
