using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGameScene : MonoBehaviour
{
    [SerializeField]
    [Header("�J�ڂ���V�[���̖��O")] string SceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
