using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeScene1(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
