using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float _time;
    private float _maxTime = 50;
    private int _hour;
    [SerializeField] private GameObject _adolfAndreevich;
    [SerializeField] private GameObject _skovorodka;
    [SerializeField] private Text _text;
    [SerializeField] private SceneController _sceneController;
    [SerializeField] private KyzykhaEvilScrimmer _kyzykhaEvil;
    [SerializeField] private GameObject _kyzylhaPicture;


    private void Start()
    {
        _kyzykhaEvil.OffKyzykhaEvilAnim();
    }

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

        if (_hour >= 2)
            _adolfAndreevich.SetActive(true);
        if (_hour == 3)
            _kyzykhaEvil.OnKyzykhaEvilAnim();
        if (_hour >= 3)
            _kyzylhaPicture.SetActive(true);
        if (_hour >= 4)
            _skovorodka.SetActive(true);

        if(_hour > 6)
            _sceneController.Scenes(2);

        _text.text = _hour + ".AM";
    }
}
