using UnityEngine;

public class PopupLoader : MonoBehaviour
{
    [SerializeField]
    private Transform popupFolder;
    public void OpenPopup(GameObject gameObject)
    {
        CloseAllPopup();
        gameObject.SetActive(true);
    }

    public void ClosePopup(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void CloseAllPopup()
    {
        foreach(Transform child in popupFolder)
        {
            child.gameObject.SetActive(false);
        }
    }
}
