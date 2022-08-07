using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    //<======== このクラスで使用する値 ========>//
    /// <summary> ギズモを表示するかどうか </summary>
    [Header("デバッグ用ギズモを表示するかどうか"), SerializeField] bool _isGizmo;
    Rigidbody _rigidbody;

    //<===== インスペクタから設定すべき値 =====>//
    [Header("移動速度"), SerializeField] float _moveSpeed;
    [Header("確認用 : 移動ベクトル"), SerializeField] Vector3 newVelocity;

    [Header("リザルトシーン名"), SerializeField] string _resultSceneName;
    [Header("タイトルシーン名"), SerializeField] string _titleSceneName;

    //<========== プロパティ一覧 ==========>
    /// <summary> プレイヤーの移動速度 </summary>
    public float MoveSpeed { get => _moveSpeed; }

    void Start()
    {
        //コンポーネントを取得
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    /// <summary> 移動処理 </summary>
    void Move()
    {
        //入力ベクトルを取得
        float inputV = Input.GetAxisRaw("Vertical");
        float inputH = Input.GetAxisRaw("Horizontal");
        newVelocity = new Vector3(inputH, 0, inputV).normalized;

        //速度を与える
        newVelocity.y = 0;
        _rigidbody.velocity = newVelocity * _moveSpeed + Vector3.up * _rigidbody.velocity.y;
    }

    //ゴールと接触したらリザルトシーンを読み込む
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("ゴール！");
            SceneManager.LoadScene(_resultSceneName);
        }
    }

    /// <summary> ボタンから呼び出す。シーンを再度読み込む。 </summary>
    public void OnClickButton_ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary> ボタンから呼び出す。タイトルシーンを読み込む。 </summary>
    public void OnClickButton_BackToTitle()
    {
        SceneManager.LoadScene(_titleSceneName);
    }
}
