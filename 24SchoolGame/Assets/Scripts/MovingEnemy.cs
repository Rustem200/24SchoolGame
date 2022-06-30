using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPosition;
    [SerializeField] private float _movingEnemyTime;
    [SerializeField] private Enemy[] _enemy;
    private int _enemyIndex;

    private void Start()
    {
        StartCoroutine(Moving());
    }

    IEnumerator Moving()
    {
        while (true)
        {
            yield return new WaitForSeconds(_movingEnemyTime);
            _enemyPosition[_enemyIndex].SetActive(false);
            _enemy[_enemyIndex].enemyIndex = _enemyIndex;
            _enemyIndex++;
            _enemyPosition[_enemyIndex].SetActive(true);
        }
    }
}
