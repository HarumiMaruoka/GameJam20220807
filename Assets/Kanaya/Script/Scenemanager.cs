using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanager : MonoBehaviour
{
    public static void LoadScene(string scene) => SceneManager.LoadScene(scene);
    
}
