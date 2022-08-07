using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �R�C���ɂ���N���X
/// </summary>
public class CoinScore : MonoBehaviour
{
    /// <summary>�R�C��</summary>
    public int Coin => _coin;//�R�C���X�R�A

    int _coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICoin player))
        {
            print(ScoreManager.Instance.TotalScore(Coin));
            player.GetCoin(Coin);//ICoin���p�����Ă�����̂ɔ�������
            Destroy(this.gameObject);
        }
    }
}
