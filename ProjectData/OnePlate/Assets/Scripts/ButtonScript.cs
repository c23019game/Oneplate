using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        // メインシーンへ移動
        SceneManager.LoadScene("Demo");
    }
}