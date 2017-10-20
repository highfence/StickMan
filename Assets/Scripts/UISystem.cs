using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystem : MonoBehaviour
{
    [SerializeField]
    public Camera _uiCam;

    [SerializeField]
    public Canvas _canvas;

    private GameObject _curtain;

    public void Awake()
    {
        _curtain = GameObject.Find("Curtain");
    }

    public void AttachUI(GameObject uiObject)
    {
        uiObject.transform.SetParent(_canvas.transform);
    }

    public void AttachUIAt(GameObject uiObject, Vector3 position)
    {
        uiObject.transform.SetParent(_canvas.transform);
        uiObject.transform.position = position;
    }

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("2. Game");
    }
}
