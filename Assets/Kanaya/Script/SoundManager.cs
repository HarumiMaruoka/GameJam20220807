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
    [Header("タイトルシーンの音源")] AudioSource _titleAudioSource;

    [SerializeField]
    [Header("ゲームシーンの音源")] AudioClip _gameAudioSource;

    [SerializeField]
    [Header("リザルトシーンの音源")] AudioClip _resultAudioSource;

    /// <summary>ビルド時に呼ばれる</summary>
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

    ///<summary>タイトル画面時のBGM</summary>
    public void PlayTitleMusic() => _titleAudioSource.Play();

    ///<summary>ゴール時のSE</summary>
    public void PlayGoalSe(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>ゲームプレイ時のBGM</summary>
    public void PlayGameMusic(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>リザルト画面時のBGM</summary>
    public void PlayResultMusic(AudioClip clip)
    {
        _titleAudioSource.Stop();//今流れている音源を止める
        _titleAudioSource.clip = ResultAudioSource;//リザルト音源に変更
        _titleAudioSource.PlayOneShot(ResultAudioSource);//リザルト音源を再生
    }

    ///<summary>コイン取得時のSE</summary>
    public void PlayGetCoinSe(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);

    ///<summary>ゲームプレイ時のSE</summary>
    public void PlayStartMusic(AudioClip clip) => _titleAudioSource.PlayOneShot(clip);
}
