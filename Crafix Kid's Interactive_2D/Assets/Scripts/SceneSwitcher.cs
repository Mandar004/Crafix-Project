using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToHome()  => SceneManager.LoadScene(0);
    public void Game1()     => SceneManager.LoadScene(1);
    public void Game2()     => SceneManager.LoadScene(2);
    public void Game3()     => SceneManager.LoadScene(3);
    public void Game4()     => SceneManager.LoadScene(4);
    public void Game5()     => SceneManager.LoadScene(5);
    public void Game6()     => SceneManager.LoadScene(6);
    public void Levels()    => SceneManager.LoadScene(7);

}
