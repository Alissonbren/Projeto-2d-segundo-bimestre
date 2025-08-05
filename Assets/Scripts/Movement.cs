using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")] [SerializeField] private int speedPlayer;
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Transform transform;
    private Animator animator;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        Move();
    }



    void Move()
    {
        animator.SetBool("onMove", false);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontal, vertical);

        Vector3 movePosition = (speedPlayer * Time.fixedDeltaTime * moveDirection.normalized) + rb.position;
        rb.MovePosition(movePosition);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetBool("onMove", true);
        }

    }


}



