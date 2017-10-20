using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField]
    Camera _mainCam;

    float _accTime = 0.0f;
    Vector3 _cameraInitPosition;
    bool _isCameraWalkLeft = true;

    private void Awake()
    {
        _cameraInitPosition = _mainCam.transform.position;
    }

    private void Update()
    {
        CameraWalk();
    }

    const float walkRange = 0.4f;

    private void CameraWalk()
    {
        if (_isCameraWalkLeft)
        {
            var curPos = _mainCam.transform.position;

            curPos.x -= Time.deltaTime * 0.3f;

            _mainCam.transform.position = curPos;

            if (_mainCam.transform.position.x < _cameraInitPosition.x - walkRange)
                _isCameraWalkLeft = false;
        }
        else
        {
            var curPos = _mainCam.transform.position;

            curPos.x += Time.deltaTime * 0.3f;

            _mainCam.transform.position = curPos;

            if (_mainCam.transform.position.x > _cameraInitPosition.x + walkRange)
                _isCameraWalkLeft = true;
        }
    }
}
