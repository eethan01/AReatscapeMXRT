using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public GameObject button;
    public GameObject RewardPage;
    public GameObject button2;
    public void Start()
    {
        button.SetActive(true);
        RewardPage.SetActive(false);
        button2.SetActive(false);
    }
    public void ActivateReward()
    {
        button.SetActive(false);
        RewardPage.SetActive(true);
        button2.SetActive(true);
    }
    public void ReturnHome()
    {
        SceneManager.LoadScene("Home");

    }
}
