using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float _time;
    private float _maxTime = 5;
    private int _hour;
    [SerializeField] private Text _text;
    [SerializeField] private SceneController _sceneController;

    private void Update()
    {
        if (_time < _maxTime)
        {
            _time += Time.deltaTime;
        }
        else if (_time >= _maxTime)
        {
            _hour += 1;
            _time = 0;
        }

        if(_hour > 6)
            _sceneController.Scenes(1);

        _text.text = _hour + ".AM";
    }
}
