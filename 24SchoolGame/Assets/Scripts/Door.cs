using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _door;

    public void ClosureDoor()
    {
        _door.rotation = Quaternion.Euler(0, 0 , 0);
    }

    public void OpenDoor()
    {
        _door.rotation = Quaternion.Euler(0, 180, 0);
    }
}
