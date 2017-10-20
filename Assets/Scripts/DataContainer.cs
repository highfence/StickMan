using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoSingleton<DataContainer>
{
    public DataContainer()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public Vector2 _screenSize { get; private set; }

    public void SetScreenSize(int width, int height)
    {
        _screenSize = new Vector2(width, height);
    }

}
