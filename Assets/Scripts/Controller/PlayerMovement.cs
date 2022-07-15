using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Muvement vers")]
    [SerializeField] private float jumpForse;
    [SerializeField] private bool isGround;
    [SerializeField] private float speed;

    [Header("Settings")] 
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset;
    [SerializeField] private LayerMask groundMask;
    //[SerializeField] private Animation runAnimation;
    //[SerializeField] private Animation jumpAnimation;

    private Animator animator;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGround = false;
    }

    private void FixedUpdate()
    {
        Vector3 overlapCirculeTransform = groundColliderTransform.position;
        isGround = Physics2D.OverlapCircle(overlapCirculeTransform, jumpOffset, groundMask);
    }

    public void Move(float direction, bool isButtonJamp)
    { 
        if (isButtonJamp)
        {
            Jump();
        }

        if(Mathf.Abs(direction) > 0.01f)
        {
            HorisontalMavement(direction);
        }

    }

    private void Jump()
    {
        if (isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForse);
        }

    }

    private void HorisontalMavement (float direction)
    {
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
        //runAnimation.Play();
        //animator.SetTrigger()
    }

}
