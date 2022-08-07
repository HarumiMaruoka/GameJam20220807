using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// コインにつけるクラス
/// </summary>
public class CoinScore : MonoBehaviour
{
    // <summary>コインの効果音</summary>
    public AudioClip CoinSE => _coinSE;

    /// <summary>コインの効果音</summary>
    [SerializeField]
    AudioClip _coinSE;

    /// <summary>コイン</summary>
    public int Coin => _coin;//コインスコア


    int _coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICoin player))
        {
            //print(ScoreManager.Instance.TotalScore(Coin));
            player.GetCoin(Coin);//ICoinを継承しているものに反応する
            SoundManager.instance.PlayGetCoinSe(CoinSE);
            Destroy(this.gameObject);
        }
    }
}
