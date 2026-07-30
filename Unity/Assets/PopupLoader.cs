using UnityEngine;

public class PopupLoader : MonoBehaviour
{
    public void OpenPopup(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public void ClosePopup(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
