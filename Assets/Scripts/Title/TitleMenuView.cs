using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuView : MonoBehaviour
{
    [SerializeField] Button newGameButton;
    [SerializeField] Button continueButton;

    void Start()
    {
        newGameButton.onClick.AddListener(OnNewGameButton);
        continueButton.onClick.AddListener(OnContinueButton);
    }
    void OnNewGameButton()
    {
        SceneManager.LoadScene("Town");
    }
    void OnContinueButton()
    {
        SceneManager.LoadScene("Town");

    }
}
