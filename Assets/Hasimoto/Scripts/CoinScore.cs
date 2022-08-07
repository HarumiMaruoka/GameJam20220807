using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// コインにつけるクラス
/// </summary>
public class CoinScore : MonoBehaviour
{
    /// <summary>コイン</summary>
    public int Coin => _coin;//コインスコア

    int _coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICoin player))
        {
            print(ScoreManager.Instance.TotalScore(Coin));
            player.GetCoin(Coin);//ICoinを継承しているものに反応する
            Destroy(this.gameObject);
        }
    }
}
