//// ModelInteraction.cs
//using UnityEngine;

//// attached to model prefab
//public class ModelInteraction : MonoBehaviour
//{
//    private Renderer rend;
//    private IInteractable current;

//    public GameObject colorPanel;

//    void Awake()
//    {
//        rend = GetComponent<Renderer>(); // cache renderer
//    }

//    public void OnSelect()
//    {
//        ShowColorButtons(this); // show UI
//    }

//    public void OnDeselect()
//    {
//        HideColorButtons(); // hide UI
//    }

//    public void ChangeColor(Color color)
//    {
//        rend.material.color = color; // change color
//    }

//    public void ShowColorButtons(IInteractable obj)
//    {
//        current = obj;
//        colorPanel.SetActive(true);
//    }

//    public void HideColorButtons()
//    {
//        colorPanel.SetActive(false);
//        current = null;
//    }

//    // button functions
//    public void SetRed() => current?.ChangeColor(Color.red);
//    public void SetGreen() => current?.ChangeColor(Color.green);
//    public void SetBlue() => current?.ChangeColor(Color.blue);
//}