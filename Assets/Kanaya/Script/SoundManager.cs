using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioSource TitleAudioSource => _titleAudioSource;
    public AudioClip ResultAudioSource => _resultAudioSource;
    public AudioClip GameAudioSource => _gameAudioSource;

    [SerializeField]
    [Header("�^�C�g���V�[���̉���")] AudioSource _titleAudioSource;

    [SerializeField]
    [Header("�Q�[���V�[���̉���")] AudioClip _gameAudioSource;

    [SerializeField]
    [Header("���U���g�V�[���̉���")] AudioClip _resultAudioSource;

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
    public void PlayGoalSe(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>�Q�[���v���C����BGM</summary>
    public void PlayGameMusic(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>���U���g��ʎ���BGM</summary>
    public void PlayResultMusic(AudioClip clip)
    {
        _titleAudioSource.Stop();//������Ă��鉹�����~�߂�
        _titleAudioSource.clip = ResultAudioSource;//���U���g�����ɕύX
        _titleAudioSource.PlayOneShot(ResultAudioSource);//���U���g�������Đ�
    }

    ///<summary>�R�C���擾����SE</summary>
    public void PlayGetCoinSe(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>�Q�[���v���C����SE</summary>
    public void PlayStartMusic(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);
}
