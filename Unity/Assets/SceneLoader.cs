using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGachaScene()
    {
        SceneManager.LoadScene("Gacha");
    }

    public void LoadFriendScene()
    {
        SceneManager.LoadScene("Friend");
    }

    public void LoadAchievementScene()
    {
        SceneManager.LoadScene("Achievement");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}