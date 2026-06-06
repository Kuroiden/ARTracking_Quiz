using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class TrackingModeSelection : MonoBehaviour, IARTrackingMode
{
    //ModeSelectionView _mainMenu;

    public ARTrackingMode Mode => ARTrackingMode.None;

    public ModeSelectionView _modeSelection;
    public ARTrackingManager _arTrackingManager;


    protected void Awake()
    {
        _arTrackingManager.SetMode(Mode);
        
        //_mainMenu = FindFirstObjectByType<ModeSelectionView>();

        //_mainMenu.ShowView();
        //_uiManager.ShowScreen(UIScreenType.ModeSelection);

        //Debug.Log($"Current mode: {_currentMode.Mode}");
    }

    public void Initialize()
    {
        _modeSelection.ShowView();

        throw new System.NotImplementedException();
    }

    public void EnableMode()
    {
        EnhancedTouchSupport.Enable();
    }

    public void DisableMode()
    {
        EnhancedTouchSupport.Disable();
    }

    public void UpdateMode() { Debug.Log($"Current Mode: {Mode}"); }

    public void ReturnToMenu()
    {
        ARTrackingManager.Instance.SetMode(ARTrackingMode.None);
        UIManager.Instance.ShowScreen(UIScreenType.ModeSelection);
    }
}
