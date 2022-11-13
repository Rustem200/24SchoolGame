using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyzykhaEvilScrimmer : MonoBehaviour
{
    [SerializeField] private Animator _anim;

    public void OnKyzykhaEvilAnim()
    {
        _anim.SetBool("KyzykhaEvil", true);
    }

    public void OffKyzykhaEvilAnim()
    {
        _anim.SetBool("KyzykhaEvil", false);
    }
}
