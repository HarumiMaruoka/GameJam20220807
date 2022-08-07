using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> キューブを並べるクラス </summary>
public class LineUp_Floor : MonoBehaviour
{
    [Header("一辺の長さ"), SerializeField] int _oneSideLength;

    [Header("床キューブのプレハブ"), SerializeField] GameObject _floorCube;

    void Start()
    {
        //床を並べる
        LineUp_FloorCube();
    }

    void Update()
    {

    }

    /// <summary> 床を並べる </summary>
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
