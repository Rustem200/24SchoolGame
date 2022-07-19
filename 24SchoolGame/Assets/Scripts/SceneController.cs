using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void Scenes(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
