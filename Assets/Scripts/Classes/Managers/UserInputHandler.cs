using UnityEngine;

public class UserInputHandler : Singleton<UserInputHandler>
{
    ModeSelectionView _mainMenu;
    IARTrackingMode _currentMode;

    protected override void Awake()
    {
        _mainMenu = FindFirstObjectByType<ModeSelectionView>();
        
        _mainMenu.ShowView();
        //UIManager.Instance.ShowScreen(UIScreenType.ModeSelection);

        //Debug.Log($"Current mode: {_currentMode.Mode}");
    }

    public void ReturnToMenu()
    {
        ARTrackingManager.Instance.SetMode(ARTrackingMode.None);
        UIManager.Instance.ShowScreen(UIScreenType.ModeSelection);
    }
}
