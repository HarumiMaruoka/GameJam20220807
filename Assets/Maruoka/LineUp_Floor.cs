using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> �L���[�u����ׂ�N���X </summary>
public class LineUp_Floor : MonoBehaviour
{
    [Header("��ӂ̒���"), SerializeField] int _oneSideLength;

    [Header("���L���[�u�̃v���n�u"), SerializeField] GameObject _floorCube;

    void Start()
    {
        //������ׂ�
        LineUp_FloorCube();
    }

    void Update()
    {

    }

    /// <summary> ������ׂ� </summary>
    void LineUp_FloorCube()
    {
        for (int i = 0; i < _oneSideLength; i++)
        {
            for (int j = 0; j < _oneSideLength; j++)
            {
                Instantiate(_floorCube, new Vector3(j - _oneSideLength / 2, 0f, i - _oneSideLength / 2), Quaternion.identity);
            }
        }
    }
}
