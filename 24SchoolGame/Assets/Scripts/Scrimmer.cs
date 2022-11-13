using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrimmer : MonoBehaviour
{
    [SerializeField] private SceneController _sceneController;

    private void Update()
    {
        StartCoroutine(BackToMenu());
    }

    IEnumerator BackToMenu()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
            _sceneController.Scenes(0);
        }
    }
}
