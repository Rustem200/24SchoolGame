using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCamers : MonoBehaviour
{
    [SerializeField] private GameObject[] _camers;
    private int _currentIndex = 0;

    public void Switching(int index)
    {
        _camers[_currentIndex].SetActive(false);
        _currentIndex = index;
        _camers[_currentIndex].SetActive(true);
    }


}
