using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void GoToRedeemCode()
    {
        SceneManager.LoadScene("Redeem");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("ARMenu");
    }
}
