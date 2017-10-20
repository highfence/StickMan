using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchManager : MonoBehaviour
{
    SpriteRenderer _loadingRenderer;

    private void Awake()
    {
        Screen.SetResolution(800, 600, false);

        _loadingRenderer = this.GetComponent<SpriteRenderer>();

        StartCoroutine("PlayLoadingScene");
    }

    IEnumerator PlayLoadingScene()
    {
        var curColor = _loadingRenderer.color;
        curColor.a = 0.0f;
        _loadingRenderer.color = curColor;

        while (_loadingRenderer.color.a < 1.0f)
        {
            curColor.a += 0.05f;
            _loadingRenderer.color = curColor;

            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("1. Start");
    }
}
