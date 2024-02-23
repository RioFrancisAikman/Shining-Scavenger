using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    public float jumpForce;

    public Rigidbody rb;
    private bool isGrounded;
    public EnergyProjectile energyProjectile;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        rotationSpeed = 500f;
        jumpForce = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        if (movement != Vector3.zero) //character rotation
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime); //Specifying how I want the character to rotate
            //animator.SetBool("IsMoving", true);      
        }
        else
        {
            //animator.SetBool("IsMoving", false);
        }
       
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //animator.SetBool("IsJumping", true);

            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; 
        }
    }
}
