using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    #region SINGLETON

    private static DataContainer _instance = null;

    private void Awake()
    {
        Initialize();
        DontDestroyOnLoad(this.gameObject);
    }

    public static DataContainer GetInstance()
    {
        if (_instance == null)
        {
            _instance = Instantiate(Resources.Load("Prefabs/DataContainer") as GameObject).GetComponent<DataContainer>();
        }
        return _instance;
    }

    // 초기화 메소드.
    // 보유 자료중에 초기화가 필요한 자료가 있다면 여기서 처리.
    public void Initialize()
    {
    }

    #endregion

    public Vector2 _screenSize { get; private set; }
    public Upgrades _upgrades { get; private set; }

    public void SetScreenSize(int width, int height)
    {
        _screenSize = new Vector2(width, height);
    }

}

public struct Upgrades
{

}

