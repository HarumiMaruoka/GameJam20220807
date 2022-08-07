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
    [Header("タイトルシーンの音源")] AudioSource _titleAudioSource;

    [SerializeField]
    [Header("ゲームシーンの音源")] AudioClip _gameAudioSource;

    [SerializeField]
    [Header("リザルトシーンの音源")] AudioClip _resultAudioSource;

    [SerializeField]
    [Header("ゴール時の音源")] AudioClip _goalSe;
    
    [SerializeField]
    [Header("スタート時の音源")] AudioClip _startSe;

    [SerializeField]
    [Header("クリック時の音源")] AudioClip _clickSe;

    [SerializeField]
    [Header("コイン取得時の音源")] AudioClip _coinGetSe;

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
    public void PlayGoalSe() => _titleAudioSource.PlayOneShot(GoalSe);

    ///<summary>ゲームプレイ時のBGM</summary>
    public void PlayGameMusic() => _titleAudioSource.PlayOneShot(GameAudioSource);

    ///<summary>リザルト画面時のBGM</summary>
    public void PlayResultMusic()
    {
        _titleAudioSource.Stop();//今流れている音源を止める
        _titleAudioSource.clip = ResultAudioSource;//リザルト音源に変更
        _titleAudioSource.PlayOneShot(ResultAudioSource);//リザルト音源を再生
    }

    ///<summary>コイン取得時のSE</summary>
    public void PlayGetCoinSe() => _titleAudioSource.PlayOneShot(CoinGetSe);

    ///<summary>ゲームプレイ時のSE</summary>
    public void PlayStartMusic() => _titleAudioSource.PlayOneShot(StartSe);
}
