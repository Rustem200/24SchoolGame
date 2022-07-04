using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPosition;
    [SerializeField] private float _movingEnemyTime;
    [SerializeField] private Enemy[] _enemy;
    [SerializeField] private int _enemySize;
    [SerializeField]private int _enemyIndex;

    private void Start()
    {
        StartCoroutine(Moving());
        _enemyIndex = 0;
        _enemyPosition[_enemySize].SetActive(false);
    }

    public void StartMoving()
    {
        StartCoroutine(Moving());
        _enemyIndex = Random.Range(0, _enemyPosition.Length);
        _enemyPosition[_enemySize].SetActive(false);
    }




    public IEnumerator Moving()
    {
        while (true)
        {
            yield return new WaitForSeconds(_movingEnemyTime);
            _enemyPosition[_enemyIndex].SetActive(false);
            _enemy[_enemyIndex].enemyIndex = _enemyIndex;
            _enemyIndex++;

            if (_enemyIndex == _enemySize)
            {
                StopAllCoroutines();
            }
            _enemyPosition[_enemyIndex].SetActive(true);

        }
    }

}
