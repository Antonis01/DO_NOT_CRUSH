using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwordForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpAmount = 10;
    private bool GroundCheck = true;
    private int JumpCnt = 1;

    private float vertical;

    private Rigidbody body;
    public float speed;
    public float rotationSpeed;
    private float horizontal;
    void Start()
    {
        body = GetComponent<Rigidbody>();

    }
   
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwordForce * Time.deltaTime);   //Add a forword force

        //vertical = Input.GetAxis("Vertical");
        //rb.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
        //An den eiha walls mporw na to valw auto etsi oste an pesei sto keno na vgei to EndGame
        if (rb.position.y < -5f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
            
       // horizontal = Input.GetAxis("Horizontal");
        //rb.velocity = (transform.right * horizontal) * speed * Time.fixedDeltaTime;

    }
    void Update()
    {

             if (Input.GetKey("d"))
             {
                 rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             }

             if (Input.GetKey("a"))
             {
                 rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             } 

            if (Input.GetKeyDown(KeyCode.Space) && GroundCheck && JumpCnt > 0)
            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
                GroundCheck = false;
                JumpCnt--;
            }


    }



    
}