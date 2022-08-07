using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    //<======== ���̃N���X�Ŏg�p����l ========>//
    /// <summary> �M�Y����\�����邩�ǂ��� </summary>
    [Header("�f�o�b�O�p�M�Y����\�����邩�ǂ���"), SerializeField] bool _isGizmo;
    Rigidbody _rigidbody;

    //<===== �C���X�y�N�^����ݒ肷�ׂ��l =====>//
    [Header("�ړ����x"), SerializeField] float _moveSpeed;
    [Header("�m�F�p : �ړ��x�N�g��"), SerializeField] Vector3 newVelocity;

    //<========== �v���p�e�B�ꗗ ==========>
    /// <summary> �v���C���[�̈ړ����x </summary>
    public float MoveSpeed { get => _moveSpeed; }

    void Start()
    {
        //�R���|�[�l���g���擾
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    /// <summary> �ړ����� </summary>
    void Move()
    {
        //���̓x�N�g�����擾
        float inputV = Input.GetAxisRaw("Vertical");
        float inputH = Input.GetAxisRaw("Horizontal");
        newVelocity = new Vector3(inputH, 0, inputV).normalized;

        //���x��^����
        newVelocity.y = 0;
        _rigidbody.velocity = newVelocity * _moveSpeed + Vector3.up * _rigidbody.velocity.y;
    }
}
