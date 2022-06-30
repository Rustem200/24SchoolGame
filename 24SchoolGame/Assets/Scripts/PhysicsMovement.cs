using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;


    public void Move(Vector3 direction)
    {
        Vector3 offset = direction * (_speed * Time.deltaTime);
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    public void RotateCharacter(Vector3 moveDirection)
    {
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, _rotateSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
