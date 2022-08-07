using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �X�R�A�}�l�[�W���[�̃N���X
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>�X�R�A�}�l�[�W���[</summary>
    public static ScoreManager Instance = null;

    /// <summary>�Q�b�g�o����R�C����</summary>
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
