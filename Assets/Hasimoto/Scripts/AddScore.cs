using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �X�R�A�����Z����N���X
/// </summary>
public class AddScore : MonoBehaviour,ICoin
{
    /// <summary>�R�C���v���p�e�B</summary>
    public int Coin => _coin;

    /// <summary>�Q�b�g�o����R�C����</summary>
    [SerializeField]
    [Header("�Q�b�g�o����R�C����")]
    int _coin;

    public void GetCoin(int coin) => ScoreManager.Instance.TotalScore(Coin);
}
