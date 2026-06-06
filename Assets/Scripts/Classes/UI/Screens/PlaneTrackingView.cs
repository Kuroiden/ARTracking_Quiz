using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;

public class PlaneTrackingView : ScreenView
{
    [SerializeField]
    private GameObject _moveAroundInstructions;
    [SerializeField]
    private GameObject _tapToSpawnInstructions;

    private ARPlaneManager planeManager;

    public void OnEnable()
    {
        if (planeManager == null) planeManager = FindFirstObjectByType<ARPlaneManager>();
    }

    public override void UpdateView()
    {
        if (planeManager.trackables.count <= 0 && !_moveAroundInstructions.activeSelf)
        {
            _moveAroundInstructions.SetActive(true);
            _tapToSpawnInstructions.SetActive(false);
        }
        else
        {
            _moveAroundInstructions.SetActive(false);
            _tapToSpawnInstructions.SetActive(true);
        }
    }
}
