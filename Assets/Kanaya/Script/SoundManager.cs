using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioClip GoalSe => _goalSe;
    public AudioClip StartSe => _startSe;
    public AudioClip ClickSe => _clickSe;
    public AudioClip CoinGetSe => _coinGetSe;

    public AudioSource TitleAudioSource => _titleAudioSource;
    public AudioClip ResultAudioSource => _resultAudioSource;
    public AudioClip GameAudioSource => _gameAudioSource;

    [SerializeField]
    [Header("�^�C�g���V�[���̉���")] AudioSource _titleAudioSource;

    [SerializeField]
    [Header("�Q�[���V�[���̉���")] AudioClip _gameAudioSource;

    [SerializeField]
    [Header("���U���g�V�[���̉���")] AudioClip _resultAudioSource;

    [SerializeField]
    [Header("�S�[�����̉���")] AudioClip _goalSe;
    
    [SerializeField]
    [Header("�X�^�[�g���̉���")] AudioClip _startSe;

    [SerializeField]
    [Header("�N���b�N���̉���")] AudioClip _clickSe;

    [SerializeField]
    [Header("�R�C���擾���̉���")] AudioClip _coinGetSe;

    /// <summary>�r���h���ɌĂ΂��</summary>
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    ///<summary>�^�C�g����ʎ���BGM</summary>
    public void PlayTitleMusic() => _titleAudioSource.Play();

    ///<summary>�S�[������SE</summary>
    public void PlayGoalSe() => _titleAudioSource.PlayOneShot(GoalSe);

    ///<summary>�Q�[���v���C����BGM</summary>
    public void PlayGameMusic() => _titleAudioSource.PlayOneShot(GameAudioSource);

    ///<summary>���U���g��ʎ���BGM</summary>
    public void PlayResultMusic()
    {
        _titleAudioSource.Stop();//������Ă��鉹�����~�߂�
        _titleAudioSource.clip = ResultAudioSource;//���U���g�����ɕύX
        _titleAudioSource.PlayOneShot(ResultAudioSource);//���U���g�������Đ�
    }

    ///<summary>�R�C���擾����SE</summary>
    public void PlayGetCoinSe() => _titleAudioSource.PlayOneShot(CoinGetSe);

    ///<summary>�Q�[���v���C����SE</summary>
    public void PlayStartMusic() => _titleAudioSource.PlayOneShot(StartSe);
}
