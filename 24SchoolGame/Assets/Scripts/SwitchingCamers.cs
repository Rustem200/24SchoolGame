using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCamers : MonoBehaviour
{
    [SerializeField] private GameObject[] _camers;
    private int currentIndex = 0;

    public void Switching(int index)
    {
        _camers[currentIndex].SetActive(false);
        currentIndex = index;
        _camers[currentIndex].SetActive(true);
    }
}
