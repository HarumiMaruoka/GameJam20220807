using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// スコアを加算するクラス
/// </summary>
public class AddScore : MonoBehaviour,ICoin
{
    /// <summary>コインプロパティ</summary>
    public int Coin => _coin;

    /// <summary>ゲット出来るコイン量</summary>
    [SerializeField]
    [Header("ゲット出来るコイン量")]
    int _coin;

    public void GetCoin(int coin) => ScoreManager.Instance.TotalScore(Coin);
}
