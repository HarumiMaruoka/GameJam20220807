using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGameScene : MonoBehaviour
{
    [SerializeField]
    [Header("遷移するシーンの名前")] string SceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
