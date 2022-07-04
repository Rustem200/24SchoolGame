using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float _attackTime;
    [SerializeField] private GameObject _scrimmer;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private ScaringEnemy _scaringEnemy;
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
            if (_scaringEnemy.isScaring == false)
            {
                _enemy.SetActive(false);
                _scrimmer.SetActive(true);
            }
            else if(_scaringEnemy.isScaring == true)
            {
                _movingEnemy.StartMoving();
                _scaringEnemy.Scaring();
                _scaringObject.SetActive(false);
            }
        }
    }
}
