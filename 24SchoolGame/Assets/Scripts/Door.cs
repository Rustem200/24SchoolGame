using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    [SerializeField] private float _speed;


    public void ClosureDoor()
    {
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * _speed);
    }

    public void OpenDoor()
    {
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(0, 0, 90));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * _speed);
    }
}
