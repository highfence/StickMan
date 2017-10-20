﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    [SerializeField]
    public Camera _uiCam;

    [SerializeField]
    public Canvas _canvas;

    public void AttachUI(GameObject uiObject)
    {
        uiObject.transform.SetParent(_canvas.transform);
    }

    public void AttachUIAt(GameObject uiObject, Vector3 position)
    {
        uiObject.transform.SetParent(_canvas.transform);
        uiObject.transform.position = position;
    }
}
