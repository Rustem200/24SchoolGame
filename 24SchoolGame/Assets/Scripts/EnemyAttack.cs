using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _attackTime;
    [SerializeField] private GameObject _scrimmer;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private ScaringEnemy _scaring;
    [SerializeField] private MovingEnemy _movingEnemy;
    [SerializeField] private GameObject _scaringObject;
    

    private void Update()
    {
        StartCoroutine(Attack());
        _scaringObject.SetActive(true);
    }

    IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(_attackTime);
            if (_scaring.isScaring == false)
            {
                _enemy.SetActive(false);
                _scrimmer.SetActive(true);
            }
            else if(_scaring.isScaring == true)
            {
                _movingEnemy.StartMoving();
                _scaring.Scaring();
                _scaringObject.SetActive(false);
            }
        }
    }
}
