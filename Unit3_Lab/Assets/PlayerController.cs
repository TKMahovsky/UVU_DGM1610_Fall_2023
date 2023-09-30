using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 60f;
    [SerializeField] private float gravity = 100f;

    private CharacterController _controller;
    private Vector3 _moveDirection;
    private bool _isJumping;
    private bool _isGrounded;
    private float _vertVelocity = 0.0f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius);
        
        if (_isGrounded)
        {
            _vertVelocity = -gravity * Time.deltaTime;
        }
        else
        {
            _vertVelocity -= gravity * Time.deltaTime;
        }
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        _controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        
        if (_isGrounded && Input.GetButtonDown("Jump"))
        {
            _vertVelocity = jumpForce;
            _isJumping = true;
        }
        
        _controller.Move(new Vector3(0, _vertVelocity, 0) * Time.deltaTime);
        
    }
}
