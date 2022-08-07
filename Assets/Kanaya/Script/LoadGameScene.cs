using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGameScene : MonoBehaviour
{
    [SerializeField]
    [Header("‘JˆÚ‚·‚éƒV[ƒ“‚Ì–¼‘O")] string SceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
