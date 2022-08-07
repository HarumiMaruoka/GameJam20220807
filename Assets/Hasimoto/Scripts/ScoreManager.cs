using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// スコアマネージャーのクラス
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>スコアマネージャー</summary>
    public static ScoreManager Instance = null;

    /// <summary>ゲット出来るコイン量</summary>
    public int Coin => _coin;


    int _coin;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public int TotalScore(int score) => _coin += score;
}
