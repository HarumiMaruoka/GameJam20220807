using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// UIManager�N���X
/// </summary>
public class UIManager : MonoBehaviour
{
    /// <summary>UIManager�̃C���X�^���X</summary>
    //public static UIManager Instance = null;

    ///// <summary>�V�[���̖��O</summary>
    //public string SceneName => _sceneName;

    ///// <summary>�J���E���g�_�E���ϐ�</summary>
    //[SerializeField]
    //float _countdown = 0.0f;

    ///// <summary>�J���E���g�_�E���e�L�X�g</summary>
    //[SerializeField]
    //Text _timeText;

    ///// <summary>�V�[���̖��O</summary>
    //string _sceneName;

    ///// <summary>���|�[�Y�����𔻒f����</summary>
    //bool isPose = false;

    private void Awake()
    {
        //if (Instance == null)
        //{
        //    Instance = this;
        //    DontDestroyOnLoad(this.gameObject);
        //}
        //else
        //{
        //    Destroy(this.gameObject);
        //}
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (isPose)
        //    {
        //        isPose = false;
        //    }
        //    else
        //    {
        //        isPose = true;
        //    }
        //}
        //if (isPose)
        //{
        //    _timeText.text = "�|�[�Y";

        //    return;
        //}
        //_countdown -= Time.deltaTime;

        //if(_timeText!=null)
        //_timeText.text = _countdown.ToString("f1") + "�b";

        //if (_countdown <= 0)
        //{
        //    _timeText.text = "�Q�[���I�[�o�[";
        //    Scenemanager.LoadScene(SceneName);
        //}
    }
    
}
