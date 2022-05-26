using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuestMenu : MonoBehaviour
{
    //[SerializeField] Button questButton;
    [SerializeField] Button BackButton;

    void Start()
    {
        //questButton.onClick.AddListener(OnQuestButton);
        BackButton.onClick.AddListener(OnBackButton);
    }
    /*void OnQuestButton()
    {
        SceneManager.LoadScene("Quest");
    }
    */
    void OnBackButton()
    {
        SceneManager.LoadScene("Town");

    }
}
