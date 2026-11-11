using UnityEngine;
using UnityEngine.UIElements;

public class professorController : MonoBehaviour
{

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

        animator.speed = 1.0f;

        if (vertical > 0)
        {
            animator.SetInteger("direction", 0);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("direction", 2);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("direction", 1);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("direction", 3);
        }
        else if ((vertical == 0f) && (horizontal == 0f)) {
            animator.speed = 0f;
        }
    }
}