using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public IScreenView CurrentScreen => _currentScreen;

    [SerializeField]
    private List<ScreenView> _allScreens;

    private readonly Dictionary<UIScreenType, IScreenView> _screens = new();
    private IScreenView _currentScreen;

    protected override void Awake()
    {
        base.Awake();
        // Register each screen view 
        foreach (var screenView in _screens.Values)
        {
            _screens.Add(screenView.ScreenType, screenView);
            Debug.Log($"{screenView} Added to screen views");
        }

        ShowScreen(UIScreenType.ModeSelection);
    }

    public void ShowScreen(UIScreenType targetScreenType)
    {
        // Hide current screen if it is not the target screen
        if (_currentScreen != null && _currentScreen.ScreenType != targetScreenType)
        {
            _currentScreen.HideView();
        }

        if (_screens.TryGetValue(targetScreenType, out IScreenView targetScreen))
        {
            _currentScreen = targetScreen;
            _currentScreen.ShowView();
        }
    }

    public void HideScreen(UIScreenType screenType)
    {
        if (_screens.TryGetValue(screenType, out IScreenView targetScreen))
        {
            _currentScreen = targetScreen;
            _currentScreen.HideView();
        }
    }
}
