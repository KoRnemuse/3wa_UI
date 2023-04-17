using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuManager : MonoBehaviour
{

    [SerializeField]    private CanvasGroup _canvasGroupPlaySubmenu;
    [SerializeField]    private GameObject _prefabSettingsCanvas;

   
    private void Awake()
    {
        _canvasGroupPlaySubmenu.alpha = 0f;
        _canvasGroupPlaySubmenu.interactable = false;
    }

    public void TogglePlaySubmenu ()
    {
        _canvasGroupPlaySubmenu.interactable = !_canvasGroupPlaySubmenu.interactable;
        _canvasGroupPlaySubmenu.alpha = _canvasGroupPlaySubmenu.interactable ? 1f : 0f;
    }

    public void OpenSettings()
    {
        _canvasGroupPlaySubmenu.alpha = 0f;
        _canvasGroupPlaySubmenu.interactable = false;

        Instantiate(_prefabSettingsCanvas);
    }

}
