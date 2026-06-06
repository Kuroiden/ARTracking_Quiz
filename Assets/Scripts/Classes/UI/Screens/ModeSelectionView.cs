using UnityEngine;
using UnityEngine.UI;

public class ModeSelectionView : ScreenView
{
    [Header("Buttons")]
    [SerializeField]
    private Button _planeTrackingButton;
    [SerializeField]
    private Button _imageTrackingButton;

    public override void ShowView()
    {
        base.ShowView();
        RegisterListeners();

        Debug.Log($"Resetting Menu...");
    }

    public override void HideView()
    {
        base.HideView();
        RemoveListeners();
    }
    private void RegisterListeners()
    {
        if(_planeTrackingButton != null)
            _planeTrackingButton.onClick.AddListener(OnPlaneTrackingSelected);

        if (_imageTrackingButton != null)
            _imageTrackingButton.onClick.AddListener(OnImageTrackingSelected);

        Debug.Log($"Listeners registered");
    }

    private void RemoveListeners()
    {
        if (_planeTrackingButton != null)
            _planeTrackingButton.onClick.RemoveListener(OnPlaneTrackingSelected);

        if (_imageTrackingButton != null)
            _imageTrackingButton.onClick.RemoveListener(OnImageTrackingSelected);

        Debug.LogWarning($"Listeners removed");
    }

    private void OnPlaneTrackingSelected()
    {
        ARTrackingManager.Instance.SetMode(ARTrackingMode.PlaneTracking);
    }

    private void OnImageTrackingSelected()
    {
        ARTrackingManager.Instance.SetMode(ARTrackingMode.ImageTracking);
    }
} 
