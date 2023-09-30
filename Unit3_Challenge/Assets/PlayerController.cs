using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;

    public float moveSpeed = 5.0f;
    public float sprintSpeed = 10.0f;
    private float _verticalVelocity = 0.0f;
    public float jumpForce = 5.0f;
    private bool _isGrounded;

    private bool _isCrouching = false;
    public float crouchHeight = 1.0f;
    private float _originalHeight;
    public KeyCode crouchKey = KeyCode.LeftControl;

    private bool _isSprinting = false;
    public float sprintStamina = 100.0f;
    private float _currentStamina;
    public float staminaDepletionRate = 10.0f;
    public KeyCode sprintKey = KeyCode.LeftShift;

    public float rotationSpeed = 5.0f;

    public float gravity = 9.81f;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _originalHeight = _characterController.height;
        _currentStamina = sprintStamina;
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (_isGrounded)
        {
            _verticalVelocity = -gravity * Time.deltaTime;
        }
        else
        {
            _verticalVelocity -= gravity * Time.deltaTime;
        }

        if (Input.GetKeyDown(crouchKey))
        {
            ToggleCrouch();
        }

        if (Input.GetKeyDown(sprintKey) && !_isCrouching && _currentStamina > 0)
        {
            StartSprint();
        }
        else if (Input.GetKeyUp(sprintKey) || _isCrouching || _currentStamina <= 0)
        {
            StopSprint();
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

        float speed = _isSprinting ? sprintSpeed : (_isCrouching ? moveSpeed / 2.0f : moveSpeed);
        _characterController.Move(moveDirection.normalized * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0, mouseX * rotationSpeed, 0);
        transform.Rotate(rotation);

        if (_isGrounded && Input.GetButtonDown("Jump") && !_isCrouching)
        {
            Jump();
        }

        _characterController.Move(new Vector3(0, _verticalVelocity, 0) * Time.deltaTime);

        if (_isSprinting)
        {
            _currentStamina -= staminaDepletionRate * Time.deltaTime;
            if (_currentStamina <= 0)
            {
                _currentStamina = 0;
                StopSprint();
            }
        }
        else if (_currentStamina < sprintStamina)
        {
            _currentStamina += staminaDepletionRate * Time.deltaTime;
            if (_currentStamina > sprintStamina)
            {
                _currentStamina = sprintStamina;
            }
        }
    }

    void ToggleCrouch()
    {
        _isCrouching = !_isCrouching;
        _characterController.height = _isCrouching ? crouchHeight : _originalHeight;
    }

    void StartSprint()
    {
        _isSprinting = true;
    }

    void StopSprint()
    {
        _isSprinting = false;
    }

    void Jump()
    {
        _verticalVelocity = jumpForce;
    }
}
