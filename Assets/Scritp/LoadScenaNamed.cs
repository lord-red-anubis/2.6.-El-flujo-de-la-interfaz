using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenaNamed : MonoBehaviour
{
    public void LoadScenaWithName(string scenaName)
    {
        SceneManager.LoadScene(scenaName);
    }
}
