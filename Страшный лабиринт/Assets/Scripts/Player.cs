using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedWalk;
    [SerializeField] private float _gravity;

    private CharacterController _characterController;
    private Vector3 _walkDirection;
    private Vector3 _velocity;


    private void Start()
    {
        _characterController = GetComponent<CharacterController>();    
    }

    
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");             // кнопки влево вправо на клаве и  WASD тоже
        float z = Input.GetAxis("Vertical");
        _walkDirection = transform.right * x + transform.forward * z;
    }

    private void FixedUpdate()
    {
        Walk(_walkDirection);
        Gravity(_characterController.isGrounded);
    }
                                                                                                                            
    private void Walk(Vector3 direction)
    {
        _characterController.Move(direction * _speedWalk * Time.fixedDeltaTime);
    }

    private void Gravity(bool isGrounded)
    {
        if (isGrounded && _velocity.y < 0)
        {
            _velocity.y = -1f;
        }
        _velocity.y -= _gravity * Time.fixedDeltaTime;
        _characterController.Move(_velocity * Time.fixedDeltaTime);
    }

}
