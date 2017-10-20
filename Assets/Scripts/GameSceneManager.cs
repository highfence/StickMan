using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField]
    int _curStage = 1;
    bool _isGameStarted = false;

    private void Awake()
    {
        // 플레이어 생성.

        // 

        StartCoroutine("StartStage");
    }

    IEnumerator StartStage()
    {
        // 스테이지 보여주기.

        yield return new WaitForSeconds(0.01f);

        _isGameStarted = true;
    }

    private void Update()
    {
        if (_isGameStarted)
        {
            // 게임 로직.

        }
    }

}
