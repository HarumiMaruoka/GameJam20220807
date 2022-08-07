using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// UIManagerクラス
/// </summary>
public class UIManager : MonoBehaviour
{
    /// <summary>UIManagerのインスタンス</summary>
    //public static UIManager Instance = null;

    ///// <summary>シーンの名前</summary>
    //public string SceneName => _sceneName;

    ///// <summary>カンウントダウン変数</summary>
    //[SerializeField]
    //float _countdown = 0.0f;

    ///// <summary>カンウントダウンテキスト</summary>
    //[SerializeField]
    //Text _timeText;

    ///// <summary>シーンの名前</summary>
    //string _sceneName;

    ///// <summary>今ポーズ中かを判断する</summary>
    //bool isPose = false;

    private void Awake()
    {
        //if (Instance == null)
        //{
        //    Instance = this;
        //    DontDestroyOnLoad(this.gameObject);
        //}
        //else
        //{
        //    Destroy(this.gameObject);
        //}
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (isPose)
        //    {
        //        isPose = false;
        //    }
        //    else
        //    {
        //        isPose = true;
        //    }
        //}
        //if (isPose)
        //{
        //    _timeText.text = "ポーズ";

        //    return;
        //}
        //_countdown -= Time.deltaTime;

        //if(_timeText!=null)
        //_timeText.text = _countdown.ToString("f1") + "秒";

        //if (_countdown <= 0)
        //{
        //    _timeText.text = "ゲームオーバー";
        //    Scenemanager.LoadScene(SceneName);
        //}
    }
    
}
