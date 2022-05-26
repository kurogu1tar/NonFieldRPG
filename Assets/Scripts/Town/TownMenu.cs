using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TownMenu : MonoBehaviour
{
    [SerializeField] Button questButton;
    [SerializeField] Button TitleButton;

    void Start()
    {
        questButton.onClick.AddListener(OnQuestButton);
        TitleButton.onClick.AddListener(OnTitleButton);
    }
    void OnQuestButton()
    {
        SceneManager.LoadScene("Quest");
    }
    void OnTitleButton()
    {
        SceneManager.LoadScene("Title");

    }
}

