using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 障害物キューブを配置するコンポーネント </summary>
public class LineUp_ObstacleCube : MonoBehaviour
{
    [Header("高さ"), SerializeField] int _height;
    [Header("配置するキューブのレイアウト : 0がなし。1が動かないキューブ。2が動かせるキューブ。"), SerializeField] string[] _lines;

    [Header("動かないキューブのプレハブ"), SerializeField] GameObject _dontMoveCubePrefab;
    [Header("動かせるキューブのプレハブ"), SerializeField] GameObject _canMoveCubePrefab;

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
