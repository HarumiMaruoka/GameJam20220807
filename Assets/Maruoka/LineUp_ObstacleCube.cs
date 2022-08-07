using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> ��Q���L���[�u��z�u����R���|�[�l���g </summary>
public class LineUp_ObstacleCube : MonoBehaviour
{
    [Header("����"), SerializeField] int _height;
    [Header("�z�u����L���[�u�̃��C�A�E�g : 0���Ȃ��B1�������Ȃ��L���[�u�B2����������L���[�u�B"), SerializeField] string[] _lines;

    [Header("�����Ȃ��L���[�u�̃v���n�u"), SerializeField] GameObject _dontMoveCubePrefab;
    [Header("��������L���[�u�̃v���n�u"), SerializeField] GameObject _canMoveCubePrefab;

    void Start()
    {

        for (int i = _lines.Length-1; i > -1; i--)
        {
            for (int j = 0; j < _lines[i].Length; j++)
            {
                if (_lines[i][j] == '1')
                {
                    Instantiate(_dontMoveCubePrefab, new Vector3(j - _lines.Length / 2, _height, i - _lines.Length / 2), Quaternion.identity);
                }
                else if (_lines[i][j] == '2')
                {
                    Instantiate(_canMoveCubePrefab, new Vector3(j - _lines.Length / 2, _height, i - _lines.Length / 2), Quaternion.identity);
                }
            }
        }
    }

    void Update()
    {
    }
}
